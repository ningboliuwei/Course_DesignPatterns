using System;
using System.Collections.Generic;
using System.Text;

namespace 工厂方法模式_两数计算
{
	internal class OperationSub : Operation
	{
		public override double GetResult()
		{
			double result = 0;
			result = NumberA - NumberB;
			return result;
		}
	}
}