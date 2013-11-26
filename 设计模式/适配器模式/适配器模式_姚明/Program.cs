using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式_姚明
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Player b = new Forwards("巴蒂尔");
			b.Attack();

			Player m = new Guards("麦迪");
			m.Attack();

			

			Player y = new Translator("姚明");
			y.Attack();
			y.Defense();

			Console.ReadLine();
		}
	}
}