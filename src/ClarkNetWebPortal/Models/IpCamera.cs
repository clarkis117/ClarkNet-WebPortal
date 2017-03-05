using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkNetWebPortal.Models
{
	/// <summary>
	/// example url:
	///     rtsp://admin:5CCharlieEchoADE7@192.168.1.11/ipcam_h264.sdp
	/// </summary>
	public class IpCamera : Application
	{
		/// <summary>
		/// this also includes file/resource extension
		/// </summary>
		public string VideoPath { get; set; }

		/// <summary>
		/// Vertical resolution
		/// </summary>
		//public int Height { get; set; }

		/// <summary>
		/// Horizontal resolution
		/// </summary>
		//public int Width { get; set; }

		public string GetVlcUrl()
		{
			var hostString = AtHost != null ? AtHost + NameOrIpAddress : NameOrIpAddress;

			var portString = $":{PortNumber}" ?? null;

			return $"{Protocol}://{hostString}{portString}/{VideoPath}";
		}
	}
}
