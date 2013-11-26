using System;

namespace 装饰模式_小人_装饰模式版
{
	internal class Tie : Finery
	{
		public override void Show()
		{
			Console.Write("领带 ");
			base.Show();
		}
	}
}