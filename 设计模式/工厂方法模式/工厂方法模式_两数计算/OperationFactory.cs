﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 工厂方法模式_两数计算
{
	interface IOperationFactory
	{
		Operation CreateOperation();
	}
}