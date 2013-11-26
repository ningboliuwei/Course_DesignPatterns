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
			string strNumberA = Console.ReadLine();
			Console.Write("请选择运算符号(+ - * /): ");
			string strOperate = Console.ReadLine();
			Console.Write("请输入数字B: ");
			string strNumberB = Console.ReadLine();
			string strResult = "";

			strResult = Operation.GetResult(Convert.ToDouble(strNumberA), Convert.ToDouble(strNumberB), strOperate).ToString();
			Console.WriteLine("结果是：" + strResult);
			Console.ReadLine();
		}
	}
}