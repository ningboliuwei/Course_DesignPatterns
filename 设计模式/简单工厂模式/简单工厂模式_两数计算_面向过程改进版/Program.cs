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
			try
			{
				Console.Write("请输入数字A: ");
				string strNumberA = Console.ReadLine();
				Console.Write("请选择运算符号(+ - * /): ");
				string strOperate = Console.ReadLine();
				Console.Write("请输入数字B: ");
				string strNumberB = Console.ReadLine();
				string strResult = "";

				switch (strOperate)
				{
					case "+":
						strResult = Convert.ToString(Convert.ToDouble(strNumberA) + Convert.ToDouble((strNumberB)));
						break;
					case "-":
						strResult = Convert.ToString(Convert.ToDouble(strNumberA) - Convert.ToDouble((strNumberB)));
						break;
					case "*":
						strResult = Convert.ToString(Convert.ToDouble(strNumberA) * Convert.ToDouble((strNumberB)));
						break;
					case "/":

						if (strNumberB != "0")
						{
							strResult = Convert.ToString(Convert.ToDouble(strNumberA) / Convert.ToDouble((strNumberB)));
						}
						else
						{
							strResult = "除数不能为0";
						}
						break;
				}
				Console.WriteLine("结果是: " + strResult);
				Console.ReadLine();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Console.ReadLine();
			}
		}
	}
}