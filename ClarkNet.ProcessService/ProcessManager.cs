using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace ClarkNet.WebPortal.Services
{
	public class ProcessManager : BaseService
	{
		public ProcessManager(TimeSpan statusPollerInterval, ILogger<ProcessManager> logger)
			: base(statusPollerInterval, logger)
		{
		}

		public List<Process> Processes { get; }

		public override void Run()
		{
			try
			{
				foreach (var process in Processes)
				{


				}
			}
			catch (Exception ex)
			{
				logger.LogError(0, ex, "Error running process task in process manager");
			}
		}
	}
}
