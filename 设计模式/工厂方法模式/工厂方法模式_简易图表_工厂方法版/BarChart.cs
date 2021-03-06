﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式_简易图表_工厂方法版
{
	using System.Drawing;

	internal class BarChart : Chart
	{
		public BarChart(Graphics g, Pen p)
			: base(g, p)
		{
		}

		public override void Display()
		{
			_g.DrawLine(_p, 100, 600, 600, 600);
			_g.DrawLine(_p, 100, 100, 100, 600);

			for (int i = 0; i < Data.Length - 1; i++)
			{
				_g.DrawRectangle(_p, 150 + i * 100, 600 - Data[i], 50, Data[i]);
			}
		}
	}
}