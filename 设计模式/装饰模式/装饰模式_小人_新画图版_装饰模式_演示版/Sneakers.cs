using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式_小人_新画图版_装饰模式_演示版
{
	class Sneakers : Wear
	{
		public Sneakers(Graphics g) : base(g)
		{
		}

		public override void Show()
		{
			base.Show();
			AddSneakers();
		}

		public void AddSneakers()
		{
			//shoes
			_g.FillPolygon(
				new SolidBrush(Color.GreenYellow),
				new Point[]
				{
					new Point(34, 215), new Point(29, 221), new Point(56, 226), new Point(48, 218)
				});

			_g.FillPolygon(
				new SolidBrush(Color.GreenYellow),
				new Point[]
				{
					new Point(118, 206), new Point(123, 213), new Point(147, 189), new Point(131, 196)
				});
			//shoes end
		}
	}
}