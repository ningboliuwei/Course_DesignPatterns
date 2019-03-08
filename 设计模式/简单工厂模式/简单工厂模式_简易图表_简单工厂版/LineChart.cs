using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂模式_简易图表_简单工厂版
{
	using System.Drawing;

	internal class LineChart : Chart
	{
		public LineChart(Graphics g, Pen p)
			: base(g, p)
		{
		}

		public override void Display()
		{
			_g.DrawLine(_p, 100, 600, 600, 600);
			_g.DrawLine(_p, 100, 100, 100, 600);

			for (int i = 0; i < Data.Length - 1; i++)
			{
				_g.DrawLine(_p, (i+1) * 100, 600 - Data[i], (i + 2) * 100, 600 - Data[i+1]);
			}
		}
	}
}