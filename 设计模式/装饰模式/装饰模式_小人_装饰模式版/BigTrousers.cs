using System;

namespace 装饰模式_小人_装饰模式版
{
	internal class BigTrousers : Finery
	{
		public override void Show()
		{
			Console.Write("垮裤 ");
			base.Show();
		}
	}
}