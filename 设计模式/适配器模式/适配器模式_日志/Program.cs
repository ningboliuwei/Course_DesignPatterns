using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式_日志
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			//LogHelper helper = new LogHelperAdapter();
			LogHelper helper = new LogHelper();
			helper.Write("xxx");
			helper.Write("yyy");
			helper.Write("zzz");

			Console.ReadLine();
		}
	}
}