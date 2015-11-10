using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式_小人_新画图版_装饰模式_双人版
{
	class Shirt : Wear
	{
		public Shirt(Graphics g) : base(g)
		{
		}

		public override void Show()
		{
			base.Show();
			AddShirt();
		}

		public void AddShirt()
		{
			//shirt
			_g.FillPolygon(
				new SolidBrush(Color.DarkCyan),
				new Point[]
				{
					new Point(59, 68), new Point(48, 82), new Point(59, 95), new Point(66, 85), new Point(62, 116), new Point(86, 116),
					new Point(85, 84), new Point(97, 94), new Point(100, 71), new Point(85, 65), new Point(60, 66)
				});
			//shirt end
		}
	}
}