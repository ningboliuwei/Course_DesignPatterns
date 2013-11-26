using System;

namespace 装饰模式_小人_装饰模式版
{
	internal class TShirts : Finery
	{
		public override void Show()
		{
			Console.Write("大T恤 ");
			base.Show();
		}
	}
}