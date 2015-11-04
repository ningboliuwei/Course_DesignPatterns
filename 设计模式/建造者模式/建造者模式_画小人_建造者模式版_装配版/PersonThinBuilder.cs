using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using 建造者模式_画小人_建造者模式版;

namespace 建造者模式_画小人_建造者模式_装配版
{
    internal class PersonThinBuilder : PersonBuilder
    {
        public PersonThinBuilder(Graphics g) : base(g)
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
            _person.AddPart(new ThinRightLeg(_g));
        }
    }
}