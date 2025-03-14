using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DesignPattern
{
	internal class VehicleFactory
	{
		public static IVehicle GetVehicle(string VehicleType)
		{
			IVehicle vehicletype = null;
			if(VehicleType.ToLower().Equals("bike")) {
				vehicletype = new Bike();
			}
			else if (VehicleType.ToLower().Equals("car"))
			{
				vehicletype = new Car();
			}
			return vehicletype;
		}
	}
}
