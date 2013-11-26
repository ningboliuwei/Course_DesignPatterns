using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_电脑
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			IBMPCBuilder builder = new IBMPCBuilder(); //创建IBM电脑
			//DellPCBuilder builder = new DellPCBuilder();//创建DELL电脑
			PCDirector director = new PCDirector(builder);

			director.CreatePC();

			Console.ReadLine();
		}
	}
}