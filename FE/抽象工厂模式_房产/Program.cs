using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂模式_房产
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			IFactory vFactory = new VankeFactory();
			IFactory sFactory = new SohoFactory();

			IVilla vVilla = vFactory.ProduceVilla();
			IApartment vApartment = vFactory.ProduceApartment();

			IVilla sVilla = sFactory.ProduceVilla();
			IApartment sApartment = sFactory.ProduceApartment();

			vVilla.Show();
			vApartment.Show();

			sVilla.Show();
			sApartment.Show();

			Console.ReadLine();
		}
	}
}