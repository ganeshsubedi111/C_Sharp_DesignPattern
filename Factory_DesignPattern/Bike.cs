using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DesignPattern
{

	
	internal class Bike : IVehicle
	{
		private readonly string _color;
		// Child class giving body as it inherit IVehicle
		public Bike()
        {
			this._color = "Black";
        }
        public string ColorsOfVehicle()
		{
			return this._color;
		}

		public string VehicleModel()
		{
			return "Honda Rebel 1100";
		}

		public string VehicleType()
		{
			return "Bike";
		}
	}
}
