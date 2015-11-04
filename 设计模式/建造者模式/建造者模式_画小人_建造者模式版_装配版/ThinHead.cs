using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace 建造者模式_画小人_建造者模式版
{
    class ThinHead:Part
    {
		public ThinHead(Graphics g) : base(g)
	    {

		}

		public override void Show()
        {
            _g.DrawEllipse(new Pen(Color.OrangeRed), 50, 15, 30, 30);
        }
    }
}
