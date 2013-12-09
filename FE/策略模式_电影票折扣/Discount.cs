using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式_电影票折扣
{
	abstract class Discount
	{
		public abstract void Caculate();
	}
}
