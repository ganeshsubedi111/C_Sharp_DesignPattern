using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon_DesignPattern
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SingleTonClass stc= SingleTonClass.GetInstance();
			SingleTonClass stc1 = SingleTonClass.GetInstance();
			stc.ShowMessage();
			stc1.ShowMessage();
			
		}
	}
}
