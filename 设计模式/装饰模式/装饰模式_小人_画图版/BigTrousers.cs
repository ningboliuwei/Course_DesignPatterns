#region

using System.Drawing;
using 装饰模式;

#endregion

namespace 装饰模式_小人_画图版 {
    internal class BigTrousers : Finery {
        public BigTrousers() {
        }

        public BigTrousers(Graphics g, Pen p)
            : base(g, p) {
        }

        public override void Show() {
            base.Show();
            _g.FillPolygon(
                new SolidBrush(_p.Color),
                new[] {
                    new Point(42, 130), new Point(53, 135), new Point(65, 110), new Point(77, 135), new Point(92, 130),
                    new Point(75, 95), new Point(55, 95)
                });
        }
    }
}