using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂模式_简易图表_简单工厂版
{
	using System.Drawing;

	internal class PieChart : Chart
	{
		public PieChart(Graphics g, Pen p)
			: base(g, p)
		{
		}

		public override void Display()
		{
			int sum = 0;

			for (int i = 0; i < Data.Length; i++)
			{
				sum = sum + Data[i];
			}

			int lastAngle = -90;

			for (int i = 0; i < Data.Length - 1; i++)
			{
				_g.DrawPie(_p, 150, 150, 400, 400, lastAngle, Convert.ToInt32(360 * Data[i] / sum));
				lastAngle = lastAngle + Convert.ToInt32(360 * Data[i] / sum);
			}
			_g.DrawEllipse(_p, 150, 150, 400, 400);
		}
	}
}