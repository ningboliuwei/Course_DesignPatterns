using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式_汽车
{
	internal class GasonlineEngineFactory : EngineFactory
	{
		public override Engine MakeEngine()
		{
			return new GasolineEngine();
		}
	}
}