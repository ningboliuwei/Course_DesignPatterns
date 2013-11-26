using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式_形状
{
	internal class Matrix : Shape
	{
		public override void Draw()
		{
			Console.Write("□");
		}
	}
}