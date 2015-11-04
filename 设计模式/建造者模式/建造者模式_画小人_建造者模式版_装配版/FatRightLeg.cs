using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace 建造者模式_画小人_建造者模式版
{
    class FatRightLeg : Part
    {
        public FatRightLeg(Graphics g) : base(g)
        {
        }

        public override void Show()
        {
            _g.TranslateTransform(65, 100);
            _g.RotateTransform(320);
            _g.FillEllipse(new SolidBrush(Color.Navy), 0, 0, 10, 60);
            _g.ResetTransform();
        }
    }
}