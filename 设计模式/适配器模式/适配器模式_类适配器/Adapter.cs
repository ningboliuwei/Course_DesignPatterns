using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式_类适配器
{
	internal class Adapter : Adaptee, ITarget
	{
		public void Request()
		{
			SpecificRequest();
		}
	}
}