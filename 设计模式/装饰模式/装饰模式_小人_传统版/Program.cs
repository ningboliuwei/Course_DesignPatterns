using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰模式_小人_传统版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Person p = new Person("小毛");
			Console.WriteLine("\n第一种装扮");
			p.WearTShirts();
			p.WearBigTrouser();
			p.WearSneakers();
			p.Show();

			Console.WriteLine("\n第二种装扮");
			p.WearSuit();
			p.WearTie();
			p.WearLeatherShoes();
			p.Show();

			Console.ReadLine();
		}
	}
}