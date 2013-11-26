using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式_烤肉串_命令模式
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Chef chef = new Chef();
			Command bl1 = new BakeLampCommand(chef);
			Command bl2 = new BakeLampCommand(chef);
			Command bcw1 = new BakeChickenWingCommand(chef);
			Waiter waiter = new Waiter();

			waiter.SetOrder(bl1);
			waiter.SetOrder(bl2);

			waiter.SetOrder(bcw1);
			waiter.CancelOrder(bl2);

			waiter.Notify();

			Console.ReadLine();
		}
	}
}