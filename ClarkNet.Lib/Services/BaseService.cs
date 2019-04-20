using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace ClarkNet.WebPortal.Services
{
	/// <summary>
	/// Performs basic functions like polling and logging
	/// </summary>
	public abstract class BaseService : IService
	{
		private readonly IObservable<long> statusPoller;

		protected readonly IDisposable runSubscription;

		protected readonly Logger logger;

		public BaseService(TimeSpan statusPollerInterval, Logger logger)
		{
			this.logger = logger ?? throw new ArgumentNullException(nameof(logger));

			statusPoller = Observable.Interval(statusPollerInterval);

			runSubscription = statusPoller.Subscribe(x => Run());
		}

		public bool IsUpAndRunning { get; protected set; }

		public abstract void Run();
	}
}
