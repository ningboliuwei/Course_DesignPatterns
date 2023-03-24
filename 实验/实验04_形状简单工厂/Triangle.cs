#region

using System.Drawing;

#endregion

namespace 实验04_形状简单工厂 {
    public class Triangle : Shape {
        public Triangle(Color color) : base(color) {
        }

        public override void Draw(Graphics g, int x, int y) {
            Point[] points = {
                new Point(x + 25, y),
                new Point(x + 50, y + 50),
                new Point(x, y + 50)
            };
            // 根据 Point 的集合绘制多边形
            g.FillPolygon(new SolidBrush(color), points);
        }
    }
}