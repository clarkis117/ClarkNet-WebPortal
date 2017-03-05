using ClarkNetWebPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkNetWebPortal.Models
{
	public static class IApplicationHelpers
	{
		public static string GetTestUrl(this IApplication app)
		{
			return $"{app.Protocol}://{GetHostUri(app)}/{app.TestPath}";
		}

		public static string GetHomeUrl(this IApplication app)
		{
			return $"{app.Protocol}://{GetHostUri(app)}/{app.HomePath}";
		}

		public static string GetHostUri(this IApplication app)
		{
			var hostString = app.AtHost != null
				? app.AtHost + app.NameOrIpAddress : app.NameOrIpAddress;

			var portString = $":{app.PortNumber}" ?? string.Empty;

			return $"{app.Protocol}://{hostString}{portString}/";
		}
	}
}
