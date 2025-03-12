using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon_DesignPattern
{
	 sealed class SingleTonClass
	{
		private SingleTonClass() { }

		// other class directly cannot access  below
		// private static Holds a single instance.
		private static SingleTonClass stc =null;
		// Lock object for thread safety
		private static readonly object _stclock = new object();

		// below is global access point through which other class get single istance
		// Public method to get the single instance
		public static SingleTonClass GetInstance()
		{
			if (stc == null)
			{
				lock (_stclock)  // Ensure thread safety
				{
					if (stc == null)
						stc = new SingleTonClass();
				}
			}
			return stc;
		}

		public void ShowMessage() {
			Console.WriteLine("Hello from SingleTonClass!");
			Console.ReadLine();
		} 
	}

}

