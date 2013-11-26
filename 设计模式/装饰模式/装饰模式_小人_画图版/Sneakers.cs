using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using 装饰模式;

namespace 装饰模式_小人_画图版
{
	internal class Sneakers : Finery
	{
		public Sneakers()
			: base()
		{
		}

		public Sneakers(Graphics g, Pen p)
			: base(g, p)
		{
		}

		public override void Show()
		{
			_g.FillRectangle(new SolidBrush(_p.Color), 40, 150, 8, 4); //left sneaker
			_g.FillRectangle(new SolidBrush(_p.Color), 83, 150, 8, 4); //right sneaker
			base.Show();
		}
	}
}