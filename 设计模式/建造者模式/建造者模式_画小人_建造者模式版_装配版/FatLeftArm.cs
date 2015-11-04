using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace 建造者模式_画小人_建造者模式版
{
    class FatLeftArm : Part
    {
        public FatLeftArm(Graphics g) : base(g)
        {
        }

        public override void Show()
        {
            _g.TranslateTransform(50, 50);
            _g.RotateTransform(45);
            _g.FillEllipse(new SolidBrush(Color.DarkRed), 0, 0, 10, 40);
            _g.ResetTransform();
        }
    }
}