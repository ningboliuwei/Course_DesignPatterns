using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂模式_制衣
{
	internal class BusinessCoat : Coat
	{
		public override string GetCoat()
		{
			return "商务装";
		}
	}
}