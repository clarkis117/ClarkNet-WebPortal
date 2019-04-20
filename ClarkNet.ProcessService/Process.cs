using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkNet.WebPortal.Services
{
	public class Process
	{
		public string PathToExe { get; set; }

		public IReadOnlyList<SubProcess> SubProcesses { get; set; }

		public string StartArgs { get; set; }

		public string EndArgs { get; set; }

		public Func<bool> AfterStart { get; set; }

		public Func<bool> AFterEnd { get; set; }

		public int RestartIfExceedsMemSizeInMB { get; set; } = 1024;
	}

	public class SubProcess
	{
		public Process Process { get; set; }

		public int KillStartOrder { get; set; }
	}
}
