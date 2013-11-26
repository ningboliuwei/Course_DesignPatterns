using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace 装饰模式
{
	internal class Tie : Finery
	{
		public Tie()
			: base()
		{
		}

		public Tie(Graphics g, Pen p)
			: base(g, p)
		{
		}

		public override void Show()
		{
			_g.FillRectangle(new SolidBrush(_p.Color), 63, 50, 4, 35); //tie
			base.Show();
		}
	}
}