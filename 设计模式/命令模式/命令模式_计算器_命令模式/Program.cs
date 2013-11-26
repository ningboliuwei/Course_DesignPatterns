using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式_计算器_命令模式
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			User user = new User();

			user.Compute('+', 100);
			user.Compute('-', 50);
			user.Compute('*', 10);
			user.Compute('/', 2);

			user.Undo(2);
			user.Redo(1);

			Console.ReadLine();
		}
	}
}