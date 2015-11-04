using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using 建造者模式_画小人_建造者模式版;

namespace 建造者模式_画小人_建造者模式_装配版
{
	internal class PersonFatBuilder : PersonBuilder
	{
        public PersonFatBuilder(Graphics g) : base(g)
		{
			_g = g;
		}

		public override void BuildHead()
		{
			_person.AddPart(new ThinHead(_g));
		}

		public override void BuildBody()
		{
			_person.AddPart(new ThinBody(_g));

		}

		public override void BuildLeftArm()
		{
			_person.AddPart(new ThinLeftArm(_g));
		}

		public override void BuildRightArm()
		{
			_person.AddPart(new ThinRightArm(_g));
		}

		public override void BuildLeftLeg()
		{
			_person.AddPart(new ThinLeftLeg(_g));
		}

		public override void BuildRightLeg()
		{
			_person.AddPart(new ThingRightLeg(_g));
		}
	}
}