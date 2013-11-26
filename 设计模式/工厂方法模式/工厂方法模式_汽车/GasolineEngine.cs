using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using 工厂方法模式_汽车;

namespace 工厂方法模式_汽车
{
	internal class GasolineEngine : Engine
	{
		public override void Launch()
		{
			Console.WriteLine("Gasonline engine starts...");
		}
	}
}