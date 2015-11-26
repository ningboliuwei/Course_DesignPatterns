using System;
using System.Collections.Generic;
using System.Text;

namespace 策略模式_计算器_满送_策略
{
	class CaculatorDiscount : ICaculator
	{
		private double _discount;

		public CaculatorDiscount(double discount)
		{
			_discount = discount;
		}

		public override double CaculatePrice(double originalPrice)
		{
			return originalPrice*_discount;
		}
	}
}