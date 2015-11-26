using System;
using System.Collections.Generic;
using System.Text;

namespace 策略模式_计算器_满送_策略
{
	abstract class ICaculator
	{
		public abstract double CaculatePrice(double money);
	}
}