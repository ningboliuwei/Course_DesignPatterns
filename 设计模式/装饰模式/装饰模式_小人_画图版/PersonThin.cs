using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using 装饰模式_小人_画图版;

namespace 装饰模式
{
	internal class PersonThin : Person
	{
		public PersonThin()
			: base()
		{
		}

		public PersonThin(Graphics g, Pen p)
			: base(g, p)
		{
		}

		public override void Show()
		{
			_g.DrawEllipse(_p, 50, 20, 30, 30); //head
			_g.DrawRectangle(_p, 60, 50, 10, 50); //body
			_g.DrawLine(_p, 60, 50, 40, 100); //left arm
			_g.DrawLine(_p, 70, 50, 90, 100); //right arm
			_g.DrawLine(_p, 60, 100, 45, 150); //left leg
			_g.DrawLine(_p, 70, 100, 85, 150); //right leg
		}
	}
}