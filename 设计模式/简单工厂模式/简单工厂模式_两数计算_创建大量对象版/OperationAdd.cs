﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂模式_两数计算_创建大量对象版
{
	class OperationAdd : Operation
	{
		public override double GetResult()
		{
			double result = 0;
			result = NumberA + NumberB;
			return result;
		}
	}
}