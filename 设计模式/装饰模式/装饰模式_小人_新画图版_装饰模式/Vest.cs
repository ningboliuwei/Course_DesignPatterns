using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式_小人_新画图版_装饰模式
{
	class Vest : Wear
	{
		public Vest(Graphics g) : base(g)
		{
		}

		public override void Show()
		{
			base.Show();
			AddVest();
		}

		public void AddVest()
		{
			//vest 
			_g.FillPolygon(
				new SolidBrush(Color.DarkCyan),
				new Point[]
				{
								new Point(70, 70), new Point(74, 84), new Point(81, 64), new Point(84, 84), new Point(89, 86), new Point(87, 118),
								new Point(56, 118), new Point(57, 91), new Point(64, 86), new Point(65, 71)
				});
		}
	}
}