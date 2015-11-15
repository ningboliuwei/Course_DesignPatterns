using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式_小人_新画图版_装饰模式_演示版
{
	class Tie : Wear
	{
		public Tie(Graphics g) : base(g)
		{
		}

		public override void Show()
		{
			base.Show();
			AddTie();
		}

		public void AddTie()
		{
			//tie
			_g.FillPolygon(
				new SolidBrush(Color.IndianRed),
				new Point[]
				{
					new Point(71, 73), new Point(67, 118), new Point(71, 130), new Point(75, 116), new Point(73, 72)
				});

			//tie end
		}
	}
}