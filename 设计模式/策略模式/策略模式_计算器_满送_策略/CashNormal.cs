using System;
using System.Collections.Generic;
using System.Text;

namespace 策略模式_计算器_满送_策略
{
	internal class CashNormal : CashSuper
	{
		public override double AcceptCash(double money)
		{
			return money;
		}
	}
}