using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using 抽象工厂模式_房产;

namespace 抽象工厂模式_房产
{
	internal class VankeApartment : IApartment
	{
		public void Show()
		{
			Console.WriteLine("This is a Vanke Apartment");
		}
	}
}