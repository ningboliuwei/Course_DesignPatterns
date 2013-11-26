﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 工厂方法模式_两数计算
{
	internal class MulFactory : IOperationFactory
	{
		public Operation CreateOperation()
		{
			return new OperationMul();
		}
	}
}