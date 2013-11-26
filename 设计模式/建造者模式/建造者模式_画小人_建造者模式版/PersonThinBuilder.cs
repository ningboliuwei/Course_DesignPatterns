using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace 建造者模式_画小人_建造者模式版
{
	internal class PersonThinBuilder : PersonBuilder
	{
		public PersonThinBuilder(Graphics g, Pen p)
			: base(g, p)
		{
		}

		public override void BuildHead()
		{
			_g.DrawEllipse(_p, 50, 20, 30, 30); //head
		}

		public override void BuildBody()
		{
			_g.DrawRectangle(_p, 60, 50, 10, 50); //body
		}

		public override void BuildArmLeft()
		{
			_g.DrawLine(_p, 60, 50, 40, 100); //left arm
		}

		public override void BuildArmRight()
		{
			_g.DrawLine(_p, 70, 50, 90, 100); //ri_ght arm
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