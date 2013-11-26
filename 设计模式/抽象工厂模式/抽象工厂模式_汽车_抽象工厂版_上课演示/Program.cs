using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂模式_汽车_抽象工厂版_上课演示
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Car car1 = new Car();
			IFactory factory = new SolarFactory();
			car1.Engine = factory.GetEngine();
			car1.Dynamo = factory.GetDynamo();

			car1.Drive();

			Console.ReadLine();
		}
	}
}