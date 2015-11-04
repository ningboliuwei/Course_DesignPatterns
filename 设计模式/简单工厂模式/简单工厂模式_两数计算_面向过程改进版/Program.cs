using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂模式_两数计算_面向过程改进版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.Write("请输入数字A: ");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.Write("请选择运算符号(+ - * /): ");
			string oper = Console.ReadLine();
			Console.Write("请输入数字B: ");
			double b = Convert.ToDouble(Console.ReadLine());
			double result = 0;
			bool ifDividedByZero = false;

			if (oper == "+")
			{
				result = a + b;
			}
			if (oper == "-")
			{
				result = a - b;
			}
			if (oper == "*")
			{
				result = a * b;
			}
			if (oper == "/")
			{
				result = a / b;
			}

			Console.WriteLine("结果是: " + result);
			Console.ReadLine();
		}
	}
}