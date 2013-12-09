using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式_电影票折扣
{
	class StudentDiscount:Discount
	{
		public override void Caculate()
		{
			Console.WriteLine("原价打8折！");
		}
	}
}
