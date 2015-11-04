﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace 建造者模式_画小人_建造者模式_装配版
{
	internal class PersonThinBuilder : PersonBuilder
	{
        public PersonThinBuilder(Graphics g, Pen p)
            : base(g, p)
        {
        }

        public override void BuildHead()
        {
            _g.DrawEllipse(new Pen(Color.OrangeRed), 50, 15, 30, 30);
        }

        public override void BuildBody()
        {
            _g.FillRectangle(new SolidBrush(Color.SandyBrown), 60, 50, 10, 50);

        }

        public override void BuildLeftArm()
        {
            _g.TranslateTransform(60, 50);
            _g.RotateTransform(45);
            _g.FillRectangle(new SolidBrush(Color.DarkRed), 0, 0, 5, 40);
            _g.ResetTransform();
        }

        public override void BuildRightArm()
        {
            _g.TranslateTransform(70, 55);
            _g.RotateTransform(290);
            _g.FillRectangle(new SolidBrush(Color.DarkRed), 0, 0, 5, 40);
            _g.ResetTransform();
        }

        public override void BuildLeftLeg()
        {
            _g.TranslateTransform(60, 100);
            _g.RotateTransform(20);
            _g.FillRectangle(new SolidBrush(Color.Navy), 0, 0, 5, 60);
            _g.ResetTransform();
        }

        public override void BuildRightLeg()
        {
            _g.TranslateTransform(65, 100);
            _g.RotateTransform(320);
            _g.FillRectangle(new SolidBrush(Color.Navy), 0, 0, 5, 60);
            _g.ResetTransform();
        }
    }
}