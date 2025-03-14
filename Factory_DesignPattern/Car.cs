using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DesignPattern
{
	internal class Car : IVehicle
	{
		private readonly string _color;
        public Car()
        {
			this._color = "Red";
        }
        public string ColorsOfVehicle()

		{
			return this._color;
		}

		public string VehicleModel()
		{
			return "Tesla Model Y";
		}

		public string VehicleType()
		{
			return "Car";
		}
	}
}
