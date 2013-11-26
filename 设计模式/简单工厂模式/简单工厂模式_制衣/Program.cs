using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂模式_制衣
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.Write("请输入服装类型: ");
			string coatType = Console.ReadLine();
			Coat coat = CoatFactory.CreateCoat(coatType);
			Console.WriteLine(coat.GetCoat());
			Console.ReadLine();
		}
	}
}