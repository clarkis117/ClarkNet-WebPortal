using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkNet.WebPortal.Wifi
{
	public class WifiConfig
	{
		public string Ssid { get; set; }

		public string Password { get; set; }

		public int PollingInterval { get; set; }
	}
}
