using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂模式_房产
{
	internal class VankeFactory : IFactory
	{
		public IVilla ProduceVilla()
		{
			return new VankeVilla();
		}

		public IApartment ProduceApartment()
		{
			return new VankeApartment();
		}
	}
}