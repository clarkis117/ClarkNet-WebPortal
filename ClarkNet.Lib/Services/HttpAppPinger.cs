using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClarkNetWebPortal.Services
{
	/*
	public class HttpAppPinger : IDisposable
	{
		private readonly HttpClient _httpClient;

		public HttpAppPinger()
		{
			_httpClient = new HttpClient();
		}

		//todo come up with better alg for checking
		public async Task<ServiceState> PingAppAsync(IApplication app, int count = 4)
		{
			int successCount = 0;

			for (int i = 0; i < count; i++)
			{
				try
				{
					var testResult = await _httpClient.GetAsync(app.GetTestUrl());

					if (testResult.IsSuccessStatusCode)
					{
						successCount++;
					}
				}
				catch (Exception)
				{
				}
			}

			if (successCount == 0)
				return ServiceState.Down;
			else if (successCount == count)
				return ServiceState.Up;
			else if (successCount < count)
				return ServiceState.Degraded;
			else
				return ServiceState.Down;
		}

		#region IDisposable Support

		private bool disposedValue = false; // To detect redundant calls

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					_httpClient.Dispose();
				}

				disposedValue = true;
			}
		}

		public void Dispose()
		{
			Dispose(true);
		}

		#endregion IDisposable Support
	}
	*/
}