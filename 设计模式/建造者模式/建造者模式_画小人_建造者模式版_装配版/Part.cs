using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace 建造者模式_画小人_建造者模式版
{
    abstract class Part
    {
        protected Graphics _g;

        public Part(Graphics g)
        {
            _g = g;
        }

        public abstract void Show();
    }
}