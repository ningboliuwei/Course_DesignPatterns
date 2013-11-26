using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂模式_汽车_非简单工厂版
{
	internal class SolarEngine : Engine
	{
		public override void Launch()
		{
			Console.WriteLine("Solar engine starts...");
		}
	}
}