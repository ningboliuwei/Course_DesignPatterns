using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace 建造者模式_画小人_工厂版
{
	internal class PersonFatBuilder
	{
		private Graphics _g;

		private Pen _p;

		public PersonFatBuilder(Graphics g, Pen p)
		{
			_g = g;
			_p = p;
		}

		public void Build()
		{
			_g.DrawEllipse(_p, 50, 20, 30, 30); //head
			_g.DrawEllipse(_p, 45, 50, 40, 50); //body
			_g.DrawLine(_p, 50, 50, 30, 100); //left arm
			_g.DrawLine(_p, 80, 50, 100, 100); //right arm
			_g.DrawLine(_p, 60, 100, 45, 150); //left leg
			_g.DrawLine(_p, 70, 100, 85, 150); //right leg
		}
	}
}