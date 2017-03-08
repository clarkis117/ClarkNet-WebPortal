using System;
using System.Threading.Tasks;

namespace ClarkNet.Lib
{
    public class Class1
    {
		public Task voi()
		{
			return Task.FromResult<object>(null);
		}

		public (int a, int b) Ver()
		{
			return (5,5);
		}
    }
}
