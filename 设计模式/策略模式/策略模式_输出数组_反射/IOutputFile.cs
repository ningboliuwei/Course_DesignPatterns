﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式_输出数组_反射
{
	internal interface IOutputFile
	{
		void OutputFile(string[] data);
	}
}