using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式_小人_新画图版_装饰模式
{
	class Jacket : Wear
	{
		public Jacket(Graphics g) : base(g)
		{
		}

		public override void Show()
		{
			base.Show();
			AddJacket();
		}

		public void AddJacket()
		{
			//jacket
			base._g.FillPolygon(
				new SolidBrush(Color.Black),
				new Point[]
				{
					new Point(63, 70), new Point(27, 104), new Point(37, 111), new Point(63, 84), new Point(63, 135),
					new Point(83, 135), new Point(83, 81), new Point(126, 98), new Point(131, 86), new Point(83, 68)
				});
			//jacket end
		}
	}
}