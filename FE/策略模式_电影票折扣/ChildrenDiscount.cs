using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式_电影票折扣
{
	class ChildrenDiscount:Discount
	{
		public override void Caculate()
		{
			Console.WriteLine("原价减去10元！");
		}
	}
}
