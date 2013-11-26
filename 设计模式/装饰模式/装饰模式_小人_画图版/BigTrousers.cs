using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using 装饰模式;

namespace 装饰模式_小人_画图版
{
	internal class BigTrousers : Finery
	{
		public BigTrousers()
			: base()
		{
		}

		public BigTrousers(Graphics g, Pen p)
			: base(g, p)
		{
		}

		public override void Show()
		{
			_g.FillPolygon(
				new SolidBrush(_p.Color),
				new Point[]
				{
					new Point(42, 130), new Point(53, 135), new Point(65, 110), new Point(77, 135), new Point(92, 130),
					new Point(75, 95), new Point(55, 95)
				});

			base.Show();
		}
	}
}