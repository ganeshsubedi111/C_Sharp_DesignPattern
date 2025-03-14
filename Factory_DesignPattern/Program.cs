using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DesignPattern
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter Vehicle Type");
			string input1=Console.ReadLine();

			IVehicle vehicle=VehicleFactory.GetVehicle(input1);
			Console.WriteLine("The Type of Vehicle  is:" + vehicle.VehicleType());
			Console.WriteLine("The Model of Vehicle  is:" + vehicle.VehicleModel());
			Console.WriteLine("The  Color of Vehicle is:" + vehicle.ColorsOfVehicle());
			Console.ReadLine();
		}
	}
}
