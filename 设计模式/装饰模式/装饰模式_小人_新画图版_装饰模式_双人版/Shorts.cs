using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式_小人_新画图版_装饰模式_双人版
{
	class Shorts : Wear
	{
		public Shorts(Graphics g) : base(g)
		{
		}

		public override void Show()
		{
			base.Show();
			AddShorts();
		}

		public void AddShorts()
		{
			//shorts
			_g.FillPolygon(
				new SolidBrush(Color.YellowGreen),
				new Point[]
				{
					new Point(60, 130), new Point(85, 130), new Point(110, 160), new Point(85, 175), new Point(75, 165),
					new Point(65, 180), new Point(45, 175)
				});
			//shorts end
		}
	}
}