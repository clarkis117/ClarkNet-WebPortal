using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace ClarkNetWebPortal.Services
{
	public class HostPinger : IDisposable
	{
		private readonly Ping _pinger;

		public HostPinger()
		{
			_pinger = new System.Net.NetworkInformation.Ping();
		}

		public async Task<IEnumerable<PingReply>> PingHostAsync(Host host, int count = 4)
		{
			var list = new List<PingReply>();

			for (int i = 0; i < count; i++)
			{
				list.Add(await _pinger.SendPingAsync(host.NameOrIpAddress));
			}

			return list;
		}

		/*
		public async Task<ServiceState> GetServiceStateAsync(Host host, int count = 4)
		{
			IEnumerable<PingReply> replies = await PingHostAsync(host,count);

			if (replies.Any(x => x.)
			{

			}
		}
		*/


		#region IDisposable Support
		private bool disposedValue = false;

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					_pinger.Dispose();
				}

				disposedValue = true;
			}
		}

		public void Dispose()
		{
			Dispose(true);
		}
		#endregion
	}
}
