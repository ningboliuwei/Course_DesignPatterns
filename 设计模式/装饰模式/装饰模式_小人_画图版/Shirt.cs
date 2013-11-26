using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using 装饰模式;

namespace 装饰模式_小人_画图版
{
	internal class Shirt : Finery
	{
		public Shirt()
			: base()
		{
		}

		public Shirt(Graphics g, Pen p)
			: base(g, p)
		{
		}

		public override void Show()
		{
			_g.FillRectangle(new SolidBrush(_p.Color), 55, 50, 20, 40);

			base.Show();
		}
	}
}