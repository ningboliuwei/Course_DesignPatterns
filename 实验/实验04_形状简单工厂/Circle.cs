#region

using System.Drawing;

#endregion

namespace 实验04_形状简单工厂 {
    public class Circle : Shape {
        public Circle(Color color) : base(color) {
        }

        public override void Draw(Graphics g, int x, int y) {
            // 绘制圆形
            g.FillEllipse(new SolidBrush(color), x, y, 50, 50);
        }
    }
}