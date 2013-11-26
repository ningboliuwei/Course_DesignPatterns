using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace 建造者模式_画小人_建造者模式版
{
	internal class PersonFatBuilder : PersonBuilder
	{
		public PersonFatBuilder(Graphics g, Pen p)
			: base(g, p)
		{
		}

		public override void BuildHead()
		{
			_g.DrawEllipse(_p, 50, 20, 30, 30); //head
		}

		public override void BuildBody()
		{
			_g.DrawEllipse(_p, 45, 50, 40, 50); //body
		}

		public override void BuildArmLeft()
		{
			_g.DrawLine(_p, 50, 50, 30, 100); //left arm
		}

		public override void BuildArmRight()
		{
			_g.DrawLine(_p, 80, 50, 100, 100); //ri_ght arm
		}

		public override void BuildLegLeft()
		{
			_g.DrawLine(_p, 60, 100, 45, 150); //left le_g
		}

		public override void BuildLegRight()
		{
			_g.DrawLine(_p, 70, 100, 85, 150); //ri_ght le_g
		}
	}
}