using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式_对象适配器
{
	internal class Target
	{
		public virtual void Request()
		{
			Console.Write("普通请求");
		}
	}
}