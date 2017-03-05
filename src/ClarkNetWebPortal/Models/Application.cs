using GenericMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkNetWebPortal.Models
{
	public interface IApplication : IHost
	{
		Application.Protocols Protocol { get; set; }

		int? PortNumber { get; set; }

		string AtHost { get; set; }

		/// <summary>
		/// path to the index page of the http app
		/// </summary>
		string HomePath { get; set; }

		/// <summary>
		/// path for the http pinger to get
		/// </summary>
		string TestPath { get; set; }
	}

	/// <summary>
	/// represents an HTTP application
	/// </summary>
	public class Application : Host, IApplication, IModel<int>
	{
		public enum Protocols : byte { http, https, rtp, srtp, rtsp };

		public Protocols Protocol { get; set; }

		public int? PortNumber { get; set; }

		public string AtHost { get; set; }

		public string HomePath { get; set; }

		public string TestPath { get; set; }
	}
}
