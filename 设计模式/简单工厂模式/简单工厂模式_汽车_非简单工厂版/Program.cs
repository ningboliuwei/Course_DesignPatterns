using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂模式_汽车_非简单工厂版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Engine gasonlineEngine1 = new GasolineEngine();
			Car gasonlineCar1 = new Car();
			gasonlineCar1.Engine = gasonlineEngine1;
			gasonlineCar1.Drive();

			Engine solarEngine1 = new SolarEngine();
			Car solarCar1 = new Car();
			solarCar1.Engine = solarEngine1;
			solarCar1.Drive();

			Engine gasonlineEngine2 = new GasolineEngine();
			Car gasonlineCar2 = new Car();
			gasonlineCar2.Engine = gasonlineEngine2;
			gasonlineCar2.Drive();

			Engine solarEngine2 = new SolarEngine();
			Car solarCar2 = new Car();
			solarCar2.Engine = solarEngine2;
			solarCar2.Drive();

			Engine gasonlineEngine3 = new GasolineEngine();
			Car gasonlineCar3 = new Car();
			gasonlineCar3.Engine = gasonlineEngine3;
			gasonlineCar3.Drive();

			Engine solarEngine3 = new SolarEngine();
			Car solarCar3 = new Car();
			solarCar3.Engine = solarEngine3;
			solarCar3.Drive();

			Engine gasonlineEngine4 = new GasolineEngine();
			Car gasonlineCar4 = new Car();
			gasonlineCar4.Engine = gasonlineEngine4;
			gasonlineCar4.Drive();

			Engine solarEngine4 = new SolarEngine();
			Car solarCar4 = new Car();
			solarCar4.Engine = solarEngine4;
			solarCar4.Drive();

			Console.ReadLine();
		}
	}
}