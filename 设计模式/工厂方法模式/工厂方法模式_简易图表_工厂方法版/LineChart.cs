#region

using System.Drawing;

#endregion

namespace 工厂方法模式_简易图表_工厂方法版 {
    internal class LineChart : Chart {
        public LineChart(Graphics g, Pen p)
            : base(g, p) {
        }

        public override void Display() {
            _g.DrawLine(_p, 100, 600, 600, 600);
            _g.DrawLine(_p, 100, 100, 100, 600);

            for (var i = 0; i < Data.Length - 1; i++) {
                _g.DrawLine(_p, 150 + i * 100, 600 - Data[i], 150 + (i + 1) * 100, 600 - Data[i + 1]);
            }
        }
    }
}