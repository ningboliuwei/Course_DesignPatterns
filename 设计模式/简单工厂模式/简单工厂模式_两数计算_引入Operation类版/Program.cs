using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂模式_两数计算_引入Operation类版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.Write("请输入数字A: ");
			double numberA = Convert.ToDouble(Console.ReadLine());
			Console.Write("请选择运算符号(+ - * /): ");
			string oper = Console.ReadLine();
			Console.Write("请输入数字B: ");
			double numberB = Convert.ToDouble(Console.ReadLine());
			double result;

			result = Operation.GetResult(numberA, oper, numberB);
			Console.WriteLine("结果是：" + result);
			Console.ReadLine();
		}
	}
}