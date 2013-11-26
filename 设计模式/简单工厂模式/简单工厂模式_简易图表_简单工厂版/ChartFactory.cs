using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂模式_简易图表_简单工厂版
{
	using System.Drawing;

	internal class ChartFactory
	{
		public static Chart CreateChart(string chartType, Graphics g, Pen p)
		{
			Chart chart;

			switch (chartType)
			{
				case "LINE":
					chart = new LineChart(g, p);
					break;
				case "PIE":
					chart = new PieChart(g, p);
					break;
				case "BAR":
					chart = new BarChart(g, p);
					break;
				default:
					chart = new LineChart(g, p);
					break;
			}

			return chart;
		}
	}
}