using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace 建造者模式_画小人_建造者模式版
{
    class ThinLeftLeg : Part
    {
        public ThinLeftLeg(Graphics g) : base(g)
        {
        }

        public override void Show()
        {
            _g.TranslateTransform(60, 100);
            _g.RotateTransform(20);
            _g.FillRectangle(new SolidBrush(Color.Navy), 0, 0, 5, 60);
            _g.ResetTransform();
        }
    }
}