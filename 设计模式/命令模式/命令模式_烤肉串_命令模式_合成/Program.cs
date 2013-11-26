using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式_烤肉串_命令模式_合成
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Chef chef = new Chef();
			CommandCombineAll combineAll = new CommandCombineAll(chef);

			combineAll.BackChickenWingCommand();
			combineAll.BakeLampCommand();
			Console.ReadLine(); //考虑调料？
		}
	}
}