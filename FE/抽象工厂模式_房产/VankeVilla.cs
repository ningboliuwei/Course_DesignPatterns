using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂模式_房产
{
	internal class VankeVilla : IVilla
	{
		public void Show()
		{
			Console.WriteLine("This is a Vanke Villa");
		}
	}
}