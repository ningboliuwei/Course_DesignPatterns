using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂模式_汽车_抽象工厂版_上课演示
{
	internal class Car
	{
		private Engine _engine;

		private Dynamo _dynamo;

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

		public Dynamo Dynamo
		{
			get
			{
				return _dynamo;
			}
			set
			{
				_dynamo = value;
			}
		}

		public void Drive()
		{
			_engine.Launch();
			_dynamo.PowerOn();
			Console.WriteLine("Car is running");
		}
	}
}