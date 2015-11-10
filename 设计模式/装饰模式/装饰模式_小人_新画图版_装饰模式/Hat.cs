using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式_小人_新画图版_装饰模式
{
	class Hat : Wear
	{
		public Hat(Graphics g) : base(g)
		{
		}

		public override void Show()
		{
			base.Show();
			AddHat();
		}

		public void AddHat()
		{
			//hat
			_g.FillPie(new SolidBrush(Color.DarkBlue), 50, 20, 45, 35, 180, 180);
			_g.DrawLine(new Pen(Color.DarkBlue, 3), 50, 37, 120, 35);
			//hat end
		}
	}
}