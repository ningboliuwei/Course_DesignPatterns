using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace 建造者模式_画小人_建造者模式_装配版
{
	internal abstract class PersonBuilder
	{
		protected Graphics _g;

		protected Pen _p;

		public PersonBuilder(Graphics g, Pen p)
		{
			_g = g;
			_p = p;
		}

		public abstract void BuildHead();

		public abstract void BuildBody();

		public abstract void BuildLeftArm();

		public abstract void BuildRightArm();

		public abstract void BuildLeftLeg();

		public abstract void BuildRightLeg();
	}
}