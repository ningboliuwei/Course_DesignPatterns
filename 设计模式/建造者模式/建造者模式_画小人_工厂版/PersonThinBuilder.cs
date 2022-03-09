#region

using System.Drawing;

#endregion

namespace 建造者模式_画小人_工厂版 {
    internal class PersonThinBuilder {
        private readonly Graphics _g;

        private Pen _p;

        public PersonThinBuilder(Graphics g, Pen p) {
            _g = g;
            _p = p;
        }

        public void Build() {
            //----------------以下为画瘦小人代码
            //head
            _g.DrawEllipse(new Pen(Color.OrangeRed), 50, 15, 30, 30);

            //body
            _g.FillRectangle(new SolidBrush(Color.SandyBrown), 60, 50, 10, 50);

            //left arm
            _g.TranslateTransform(60, 50);
            _g.RotateTransform(45);
            _g.FillRectangle(new SolidBrush(Color.DarkRed), 0, 0, 5, 40);
            _g.ResetTransform();
            //left arm end

            //body
            _g.FillRectangle(new SolidBrush(Color.SandyBrown), 60, 50, 10, 50);

            //right arm
            _g.TranslateTransform(70, 55);
            _g.RotateTransform(290);
            _g.FillRectangle(new SolidBrush(Color.DarkRed), 0, 0, 5, 40);
            _g.ResetTransform();
            //right arm end

            //left leg
            _g.TranslateTransform(60, 100);
            _g.RotateTransform(20);
            _g.FillRectangle(new SolidBrush(Color.Navy), 0, 0, 5, 60);
            _g.ResetTransform();
            //left leg end

            //right leg
            _g.TranslateTransform(65, 100);
            _g.RotateTransform(320);
            _g.FillRectangle(new SolidBrush(Color.Navy), 0, 0, 5, 60);
            _g.ResetTransform();
            //right leg end
            //----------------以上为画瘦小人代码
        }
    }
}