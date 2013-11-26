using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂模式_两数计算_面向过程版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.Write("请输入数字A: ");
			string A = Console.ReadLine();
			Console.Write("请选择运算符号(+ - * /): ");
			string B = Console.ReadLine();
			Console.Write("请输入数字B: ");
			string C = Console.ReadLine();
			string D = "";

			if (B == "+")
			{
				D = Convert.ToString(Convert.ToDouble(A) + Convert.ToDouble((C)));
			}
			if (B == "-")
			{
				D = Convert.ToString(Convert.ToDouble(A) - Convert.ToDouble((C)));
			}
			if (B == "*")
			{
				D = Convert.ToString(Convert.ToDouble(A) * Convert.ToDouble((C)));
			}
			if (B == "/")
			{
				D = Convert.ToString(Convert.ToDouble(A) / Convert.ToDouble((C)));
			}

			Console.WriteLine("结果是: " + D);
			Console.ReadLine();
		}
	}
}