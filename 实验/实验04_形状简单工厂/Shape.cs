#region

using System.Drawing;

#endregion

namespace 实验04_形状简单工厂 {
    public abstract class Shape {
        protected Color color;

        public Shape(Color color) {
            this.color = color;
        }

        public Color Color {
            get { return color; }
            set { color = value; }
        }

        public abstract void Draw(Graphics g, int x, int y);
    }
}