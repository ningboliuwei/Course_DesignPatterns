using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace 建造者模式_画小人_建造者模式版
{
    class FatBody : Part
    {
        public FatBody(Graphics g) : base(g)
        {
        }

        public override void Show()
        {
            _g.FillEllipse(new SolidBrush(Color.SandyBrown), 50, 50, 30, 50);
        }
    }
}