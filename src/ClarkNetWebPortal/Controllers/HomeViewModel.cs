using ClarkNetWebPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkNetWebPortal.ViewModels
{
	public class HomeViewModel
	{
		public IList<HostViewModel> HostViewModels { get; set; }

		public IList<ApplicationViewModel> Apps { get; set; }

		public HomeViewModel()
		{

		}

		public async Task Initialize()
		{
			try
			{
				HostViewModels = new List<HostViewModel>();

				var hosts = new List<Host>()
				{
					new Host {
						DisplayName = "Local Host",
						Id = 0,
						NameOrIpAddress = "127.0.0.1",
						Type = Host.Types.Client
					},
					new Host {
						DisplayName = "Gateway",
						Id = 1,
						NameOrIpAddress = "192.168.1.1",
						Type = Host.Types.Server
					},
					new Host {
						DisplayName = "Bad Server",
						Id = 2,
						NameOrIpAddress = "192.168.1.200",
						Type = Host.Types.Server
					},
				};

				foreach (var host in hosts)
				{
					//todo add pinger service as transient in di
					var hostviewModel = await HostViewModel.Initialize(host, new Services.HostPinger());

					HostViewModels.Add(hostviewModel);
				}
			}
			catch (Exception)
			{
				System.Console.WriteLine("View Model Error");
			}
		}
	}
}
