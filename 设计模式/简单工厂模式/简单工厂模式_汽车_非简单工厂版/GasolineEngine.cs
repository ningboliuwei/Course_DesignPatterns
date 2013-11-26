using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using 简单工厂模式_汽车_非简单工厂版;

namespace 简单工厂模式_汽车_非简单工厂版
{
	internal class GasolineEngine : Engine
	{
		public override void Launch()
		{
			Console.WriteLine("Gasonline engine starts...");
		}
	}
}