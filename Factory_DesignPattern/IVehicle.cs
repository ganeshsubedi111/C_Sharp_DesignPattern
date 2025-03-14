using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DesignPattern
{
	internal interface IVehicle
	{
		// method inside the interface are abstract meaning they donot have body. 
		// the child class who inherit this interface give body  to this method
		string VehicleType();
		string VehicleModel();
		string ColorsOfVehicle();

	}
}
