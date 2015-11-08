using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace 装饰模式_小人_新画图版_面向对象
{
	internal class PersonFat : Person
	{
		public PersonFat()
			: base()
		{
		}

		public PersonFat(Graphics g, Pen p)
			: base(g, p)
		{
		}

		public override void Show()
		{
			_g.DrawEllipse(_p, 50, 20, 30, 30); //head
			_g.DrawEllipse(_p, 45, 50, 40, 50); //body
			_g.DrawLine(_p, 45, 60, 30, 100); //left arm
			_g.DrawLine(_p, 85, 60, 100, 100); //right arm
			_g.DrawLine(_p, 60, 100, 45, 150); //left leg
			_g.DrawLine(_p, 70, 100, 85, 150); //right leg
		}
	}
}