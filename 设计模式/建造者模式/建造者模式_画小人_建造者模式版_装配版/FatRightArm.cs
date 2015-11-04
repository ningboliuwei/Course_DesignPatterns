using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace 建造者模式_画小人_建造者模式版
{
    class FatRightArm : Part
    {
        public FatRightArm(Graphics g) : base(g)
        {
        }

        public override void Show()
        {
            _g.TranslateTransform(70, 60);
            _g.RotateTransform(290);
            _g.FillEllipse(new SolidBrush(Color.DarkRed), 0, 0, 10, 40);
            _g.ResetTransform();
        }
    }
}