using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式_输出数组
{
	internal interface IOutputFile
	{
		void OutputFile(string[] data);
	}
}