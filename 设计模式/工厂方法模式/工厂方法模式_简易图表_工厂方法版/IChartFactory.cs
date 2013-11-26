using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式_简易图表_工厂方法版
{
	using System.Drawing;

	internal interface IChartFactory
	{
		Chart Create(Graphics g, Pen p);
	}
}