using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace 建造者模式_画小人_建造者模式版
{
    class ThinBody:Part
    {
	    public ThinBody(Graphics g) : base(g)
	    {
		    
	    }

        public override void Show()
        {
            _g.FillRectangle(new SolidBrush(Color.SandyBrown), 60, 50, 10, 50);
        }
    }
}
