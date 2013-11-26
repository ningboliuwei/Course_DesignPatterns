using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_电脑
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			CheapPCBuilder builder = new CheapPCBuilder(); //创建Expensive PC
			//ExpensivePCBuilder builder = new ExpensivePCBuilder();//创建Cheap PC
			PCDirector director = new PCDirector(builder);

			director.CreatePC();

			Console.ReadLine();
		}
	}
}