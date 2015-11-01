using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂模式_两数计算_引入Operation类版
{
	class Operation
	{
		public static double GetResult(double numberA, double NumberB, string operate)
		{
			double result = 0;

			switch (operate)
			{
				case "+":
					result = numberA + NumberB;
					break;
				case "-":
					result = numberA - NumberB;
					break;
				case "*":
					result = numberA * NumberB;
					break;
				case "/":
					result = numberA / NumberB;
					break;
			}
			return result;
		}
	}
}