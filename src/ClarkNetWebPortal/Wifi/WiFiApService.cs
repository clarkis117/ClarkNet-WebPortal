using ClarkNet.WebPortal.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkNet.WebPortal.Wifi
{ 
	public class WiFiApService : BaseService
	{
		private const string CommandStart = "netsh wlan";

		private const string Start = " start";

		private const string Stop = " stop";

		private const string Show = " show";

		private const string Started = "Started";

		private const string Allowed = "Allowed";

		private readonly string[] isUpConditions = { Started, Allowed };

		private const string HostedNet = "hostednetwork";

		private const string SetTemplate = " set {0} mode=allow ssid={1} key={2} keyUsage=persistent";

		private readonly string _ssid;

		private readonly string _password;

		public WiFiApService(
			WifiConfig config,
			ILogger<WiFiApService> logger) : base(TimeSpan.FromMinutes(config.PollingInterval), logger)
		{
			_ssid = config.Ssid ?? throw new ArgumentNullException(nameof(config.Ssid));

			_password = config.Password ?? throw new ArgumentNullException(nameof(config.Password));

			var result = ServiceHelper.RunCommand(string.Format(CommandStart + SetTemplate, HostedNet, _ssid, _password));

			//todo validation
		}

		private bool IsUp()
		{
			var result = ServiceHelper.RunCommand($"{CommandStart} {Show} {HostedNet}");

			IList<bool> all = new List<bool>();

			foreach (var condition in isUpConditions)
					all.Add(result.stdout.Contains(condition));

			return all.All(x => x == true);
		}

		public override void Run()
		{
			try
			{
				if (!IsUp())
				{
					logger.LogInformation("Hosted Network is down");

					var result = ServiceHelper.RunCommand($"{CommandStart} {Start} {HostedNet}");

					var normResult = result.stdout.ToLowerInvariant();

					if (!normResult.Contains("started")
						|| !normResult.Contains("hosted network started"))
					{
						logger.LogError("Hosted Network could not be started");
					}
					else
					{
						logger.LogInformation("Hosted Network started");
					}
				}
			}
			catch (Exception ex)
			{
				logger.LogCritical(new EventId(0), ex, "Something unexpected happened while running wifi service");
			}
		}
	}
}
