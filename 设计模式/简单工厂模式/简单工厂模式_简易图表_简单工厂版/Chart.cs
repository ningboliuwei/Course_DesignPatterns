using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂模式_简易图表_简单工厂版
{
	using System.Drawing;

	internal abstract class Chart
	{
		protected Graphics _g;

		protected Pen _p;

		protected int[] _data;

		public Chart(Graphics g, Pen p)
		{
			_g = g;
			_p = p;
		}

		public int[] Data { get; set; }

		public virtual void Display()
		{
		}
	}
}