#region

using System;
using System.Drawing;

#endregion

namespace 简单工厂模式_简易图表_简单工厂版 {
    internal class PieChart : Chart {
        public PieChart(Graphics g, Pen p)
            : base(g, p) {
        }

        public override void Display() {
            var sum = 0;

            for (var i = 0; i < Data.Length; i++) {
                sum = sum + Data[i];
            }

            var lastAngle = -90;

            for (var i = 0; i < Data.Length - 1; i++) {
                _g.DrawPie(_p, 150, 150, 400, 400, lastAngle, Convert.ToInt32(360 * Data[i] / sum));
                lastAngle = lastAngle + Convert.ToInt32(360 * Data[i] / sum);
            }

            _g.DrawEllipse(_p, 150, 150, 400, 400);
        }
    }
}