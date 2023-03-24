#region

using System.Drawing;

#endregion

namespace 实验04_形状简单工厂 {
    public class Rectangle : Shape {
        public Rectangle(Color color) : base(color) {
        }

        public override void Draw(Graphics g, int x, int y) {
            // 绘制矩形
            g.FillRectangle(new SolidBrush(color), x, y, 50, 50);
        }
    }
}