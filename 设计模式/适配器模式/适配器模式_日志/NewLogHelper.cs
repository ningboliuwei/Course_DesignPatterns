using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式_日志
{
	internal class NewLogHelper //客户端调用的新的类
	{
		public void WriteLog(string s)
		{
			Console.WriteLine(s);
		}
	}
}