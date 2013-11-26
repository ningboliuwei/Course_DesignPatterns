using System;
using System.Collections.Generic;
using System.Text;

namespace 策略模式_计算器_满送_工厂
{
	internal abstract class CashSuper
	{
		public abstract double AcceptCash(double money);
	}
}