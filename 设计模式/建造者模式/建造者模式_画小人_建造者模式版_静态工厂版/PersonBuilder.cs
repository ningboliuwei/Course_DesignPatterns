using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace 建造者模式_画小人_静态工厂版
{
	internal class PersonBuilder
	{
		public static void CreatePersonThin(Graphics g, Pen p)
		{
			g.DrawEllipse(p, 50, 20, 30, 30); //head
			g.DrawRectangle(p, 60, 50, 10, 50); //body
			g.DrawLine(p, 60, 50, 40, 100); //left arm
			g.DrawLine(p, 70, 50, 90, 100); //right arm
			g.DrawLine(p, 60, 100, 45, 150); //left leg
			g.DrawLine(p, 70, 100, 85, 150); //right leg
		}

		public static void CreatePersonFat(Graphics g, Pen p)
		{
			g.DrawEllipse(p, 50, 20, 30, 30); //head
			g.DrawEllipse(p, 45, 50, 40, 50); //body
			g.DrawLine(p, 50, 50, 30, 100); //left arm
			g.DrawLine(p, 80, 50, 100, 100); //right arm
			g.DrawLine(p, 60, 100, 45, 150); //left leg
			g.DrawLine(p, 70, 100, 85, 150); //right leg
		}
	}
}