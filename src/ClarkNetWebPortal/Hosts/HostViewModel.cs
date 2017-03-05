using ClarkNetWebPortal.Models;
using ClarkNetWebPortal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkNetWebPortal.ViewModels
{
	/// <summary>
	/// Up should be green, Degraded should be orange, Down should be red
	/// </summary>
	public enum ServiceState : byte { Up = 0, Degraded, Down }

	public class HostViewModel
	{
		public async static Task<HostViewModel> Initialize(Host host, HostPinger pinger, int attempts = 4)
		{
			if (host == null)
				throw new ArgumentNullException(nameof(host));

			if (pinger == null)
				throw new ArgumentNullException(nameof(pinger));


			ServiceState state = ServiceState.Up;

			int failedResponses = 0;

			try
			{
				var result = await pinger.PingHostAsync(host, attempts);

				foreach (var response in result)
				{
					if (response.Status != System.Net.NetworkInformation.IPStatus.Success)
						failedResponses++;
				}

				if (failedResponses == attempts)
					state = ServiceState.Down;
				else if (failedResponses > 0)
					state = ServiceState.Degraded;
			}
			catch (Exception)
			{
				state = ServiceState.Down;
			}

			return new HostViewModel(host, state, attempts, attempts - failedResponses);
		}

		protected HostViewModel(Host host, ServiceState state, int attemptCount, int successCount)
		{
			Host = host;
			State = state;
			AttemptCount = attemptCount;
			SuccessCount = successCount;
		}

		public Host Host { get; set; }

		public ServiceState State { get; set; }

		public int AttemptCount { get; set; }

		public int SuccessCount { get; set; }
	}
}
