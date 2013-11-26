using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂模式_汽车_抽象工厂版_上课演示
{
	internal class GasolineFactory : IFactory
	{
		public Engine GetEngine()
		{
			return new GasolineEngine();
		}

		Dynamo IFactory.GetDynamo()
		{
			return new GaslolineDynamo();
		}
	}
}