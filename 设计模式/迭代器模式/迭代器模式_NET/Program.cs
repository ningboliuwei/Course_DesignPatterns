using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 迭代器模式_NET
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			List<string> list = new List<string>();

			list.Add("张三");
			list.Add("李四");
			list.Add("王五");
			list.Add("赵六");
			list.Add("周七");

			foreach (string s in list)
			{
				Console.WriteLine(s);
			}

			Console.ReadLine();
		}
	}
}