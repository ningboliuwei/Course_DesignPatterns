using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式_汽车
{
	internal class Car
	{
		private Engine _engine;

		public Engine Engine
		{
			get
			{
				return _engine;
			}
			set
			{
				_engine = value;
			}
		}

		public void Drive()
		{
			_engine.Launch();
			Console.WriteLine("Car is running");
		}
	}
}