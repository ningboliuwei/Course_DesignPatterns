#region

using System.Drawing;

#endregion

namespace 简单工厂模式_简易图表_简单工厂版 {
    internal abstract class Chart {
        protected int[] _data;
        protected Graphics _g;

        protected Pen _p;

        public Chart(Graphics g, Pen p) {
            _g = g;
            _p = p;
        }

        public int[] Data { get; set; }

        public virtual void Display() {
        }
    }
}