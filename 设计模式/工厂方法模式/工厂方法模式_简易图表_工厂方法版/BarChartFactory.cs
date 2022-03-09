#region

using System.Drawing;

#endregion

namespace 工厂方法模式_简易图表_工厂方法版 {
    internal class BarChartFactory : IChartFactory {
        public Chart Create(Graphics g, Pen p) {
            return new BarChart(g, p);
        }
    }
}