﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂模式_两数计算_引入继承版
{
	internal class OperationMul : Operation
	{
		public override double GetResult()
		{
			double result = 0;
			result = NumberA * NumberB;
			return result;
		}
	}
}