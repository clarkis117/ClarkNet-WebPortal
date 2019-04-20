using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkNet.NPVRManager.Services
{
	public interface IService
	{
		/// <summary>
		/// 
		/// </summary>
		bool IsUpAndRunning { get; }

		void Run();
	}
}
