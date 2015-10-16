using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂模式_两数计算_创建大量对象版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			try
			{
				Operation operation1 = new OperationAdd();
				operation1.NumberA = 3;
				operation1.NumberB = 5;
				Console.WriteLine("结果是：" + operation1.GetResult());

				Operation operation2 = new OperationAdd();
				operation2.NumberA = 9;
				operation2.NumberB = 4;
				Console.WriteLine("结果是：" + operation2.GetResult());

				Operation operation3 = new OperationAdd();
				operation3.NumberA = 3;
				operation3.NumberB = 2;
				Console.WriteLine("结果是：" + operation3.GetResult());

				Operation operation4 = new OperationDiv();
				operation4.NumberA = 8;
				operation4.NumberB = 2;
				Console.WriteLine("结果是：" + operation4.GetResult());

				Operation operation5 = new OperationDiv();
				operation5.NumberA = 6;
				operation5.NumberB = 3;
				Console.WriteLine("结果是：" + operation5.GetResult());

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