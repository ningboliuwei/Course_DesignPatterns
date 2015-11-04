using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace 建造者模式_画小人_建造者模式_单小人版
{
	internal abstract class PersonBuilder
	{
		protected Graphics _g;


		public PersonBuilder(Graphics g)
		{
			_g = g;
		}

		public abstract void BuildHead();

		public abstract void BuildBody();

		public abstract void BuildLeftArm();

		public abstract void BuildRightArm();

		public abstract void BuildLeftLeg();

		public abstract void BuildRightLeg();
	}
}