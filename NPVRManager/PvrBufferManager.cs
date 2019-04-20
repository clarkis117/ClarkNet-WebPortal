using ClarkNet.NPVRManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog.Core;

namespace NPVRManager
{
	public class PvrBufferManager : BaseService
	{
		public PvrBufferManager(TimeSpan statusPollerInterval, Logger logger) : base(statusPollerInterval, logger)
		{
		}

		public override void Run()
		{
			throw new NotImplementedException();
		}
	}
}
