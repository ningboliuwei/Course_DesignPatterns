using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式_日志_类适配器
{
	internal interface ILogTarget
	{
		void Write();
	}
}