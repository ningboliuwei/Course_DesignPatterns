using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂模式_两数计算_简单工厂版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Operation operation;

			Console.Write("请输入数字A: ");
			string strNumberA = Console.ReadLine();
			Console.Write("请选择运算符号(+ - * /): ");
			string strOperate = Console.ReadLine();
			Console.Write("请输入数字B: ");
			string strNumberB = Console.ReadLine();
			string strResult = "";

			operation = OperationFactory.CreateOperation(strOperate);
			operation.NumberA = Convert.ToDouble(strNumberA);
			operation.NumberB = Convert.ToDouble(strNumberB);
			strResult = operation.GetResult().ToString();

			Console.WriteLine("结果是：" + strResult);
			Console.ReadLine();
		}
	}
}