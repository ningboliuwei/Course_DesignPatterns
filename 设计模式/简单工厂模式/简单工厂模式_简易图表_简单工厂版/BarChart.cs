#region

using System.Drawing;

#endregion

namespace 简单工厂模式_简易图表_简单工厂版 {
    internal class BarChart : Chart {
        public BarChart(Graphics g, Pen p)
            : base(g, p) {
        }

        public override void Display() {
            _g.DrawLine(_p, 100, 600, 600, 600);
            _g.DrawLine(_p, 100, 100, 100, 600);

            for (var i = 0; i <= Data.Length - 1; i++) {
                _g.DrawRectangle(_p, 150 + i * 80, 600 - Data[i], 50, Data[i]);
            }
        }
    }
}