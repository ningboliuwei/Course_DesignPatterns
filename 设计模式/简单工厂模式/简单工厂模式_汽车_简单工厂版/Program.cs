using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂模式_汽车_简单工厂版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Car car1 = new Car();
			car1.Engine = EngineFactory.MakeEngine("Gasoline");
			car1.Drive();

			Car car2 = new Car();
			car2.Engine = EngineFactory.MakeEngine("Solar");
			car2.Drive();

			Car car3 = new Car();
			car3.Engine = EngineFactory.MakeEngine("Gasoline");
			car3.Drive();

			Car car4 = new Car();
			car4.Engine = EngineFactory.MakeEngine("Solar");
			car4.Drive();

			Console.ReadLine();
		}
	}
}