using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_DesignPattern
{

	interface ICar 
	{
		void ManufactureCar();  //Abstract product
	}
	interface IBike  
	{
		void ManufactureBike();  //Abstract product
	}
	class BMW_Bike : IBike //Concreate factory
	{
		public void ManufactureBike()   
		{
			Console.WriteLine("BMW_Bike Manufacture By BMW");
		}
	}
	class BMW_Car : ICar //Concreate factory
	{
		public void ManufactureCar()
		{
			Console.WriteLine("BMW_Car Manufacture By BMW");
		}
	}
	class KTM_Bike : IBike //Concreate factory
	{
		public void ManufactureBike()
		{
			Console.WriteLine("KTM_Bike Manufacture By KTM");
		}
	}

	
	class KTM_Car : ICar //Concreate factory
	{
		public void ManufactureCar()
		{
			Console.WriteLine("KTM_Car Manufacture By KTM");
		}
	}
	interface VehicleCompany //Abstract factory 
	{
		ICar GetCar();
		IBike GetBike();
	}

	class KTM : VehicleCompany // concreate factory
	{
		public IBike GetBike()  
		{
			return new KTM_Bike();
		}

		public ICar GetCar() 
		{
			return new KTM_Car();	
		}
	}

	class BMW : VehicleCompany    // concreate factory
	{
		public IBike GetBike() 
		{
			return new BMW_Bike();
		}

		public ICar GetCar() 
		{
			return new BMW_Car();
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{

			VehicleCompany bmwCompany = new BMW();
			IBike bmwbike= bmwCompany.GetBike();
			ICar bmwcar= bmwCompany.GetCar();

			VehicleCompany ktmCompany = new KTM();
			IBike ktmbike = ktmCompany.GetBike();
			ICar ktmcar = ktmCompany.GetCar();

			bmwbike.ManufactureBike();
			bmwcar.ManufactureCar();

			ktmbike.ManufactureBike();
			ktmcar.ManufactureCar();
			Console.ReadLine();	
		}
	}
}
	