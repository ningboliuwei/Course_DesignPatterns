using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace 建造者模式_画小人_建造者模式版
{
    class ThinLeftArm:Part
    {
        protected override void Show()
        {
            _g.TranslateTransform(60, 50);
            _g.RotateTransform(45);
            _g.FillRectangle(new SolidBrush(Color.DarkRed), 0, 0, 5, 40);
            _g.ResetTransform();
        }
    }
}
