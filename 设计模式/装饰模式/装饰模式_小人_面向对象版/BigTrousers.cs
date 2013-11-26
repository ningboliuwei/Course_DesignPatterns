using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰模式_小人_面向对象版
{
	internal class BigTrousers : Finery
	{
		public override void Show()
		{
			Console.Write("垮裤 ");
		}
	}
}