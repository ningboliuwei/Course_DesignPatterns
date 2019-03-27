using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace 建造者模式_画小人_建造者模式版
{
	class PersonFatBuilder : PersonBuilder
	{
		public PersonFatBuilder(Graphics g)
			: base(g, new Pen(Color.Red))
		{
		}

		public override void BuildHead()
		{
            _g.DrawEllipse(new Pen(Color.OrangeRed), 50, 20, 30, 30);
        }

		public override void BuildBody()
		{
            _g.FillEllipse(new SolidBrush(Color.SandyBrown), 50, 50, 30, 50);
        }

        public override void BuildLeftArm()
       {
            _g.TranslateTransform(50, 50);
            _g.RotateTransform(45);
            _g.FillEllipse(new SolidBrush(Color.DarkRed), 0, 0, 10, 40);
            _g.ResetTransform();
        }

        public override void BuildRightArm()
		{
            _g.TranslateTransform(70, 60);
            _g.RotateTransform(290);
            _g.FillEllipse(new SolidBrush(Color.DarkRed), 0, 0, 10, 40);
            _g.ResetTransform();
        }

        public override void BuildLeftLeg()
		{
            _g.TranslateTransform(60, 100);
            _g.RotateTransform(20);
            _g.FillEllipse(new SolidBrush(Color.Navy), 0, 0, 10, 60);
            _g.ResetTransform();
        }

        public override void BuildRightLeg()
		{
            _g.TranslateTransform(65, 100);
            _g.RotateTransform(320);
            _g.FillEllipse(new SolidBrush(Color.Navy), 0, 0, 10, 60);
            _g.ResetTransform();
        }
    }
}