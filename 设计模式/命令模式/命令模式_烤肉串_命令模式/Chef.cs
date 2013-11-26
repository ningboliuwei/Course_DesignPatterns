using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式_烤肉串_命令模式
{
	public class Chef
	{
		public void BakeLamp()
		{
			Console.WriteLine("烤羊排");
		}

		public void BakeChickenWing()
		{
			Console.WriteLine("烤鸡翅");
		}
	}
}