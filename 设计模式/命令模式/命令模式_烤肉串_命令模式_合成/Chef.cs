using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式_烤肉串_命令模式_合成
{
	internal class Chef
	{
		public void BakeLamp()
		{
			Console.WriteLine("烤羊肉");
		}

		public void BakeChickenWing()
		{
			Console.WriteLine("烤鸡翅");
		}
	}
}