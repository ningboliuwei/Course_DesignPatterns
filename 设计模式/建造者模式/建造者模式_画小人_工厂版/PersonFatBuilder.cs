#region

using System.Drawing;

#endregion

namespace 建造者模式_画小人_工厂版 {
    internal class PersonFatBuilder {
        private readonly Graphics _g;

        private Pen _p;

        public PersonFatBuilder(Graphics g, Pen p) {
            _g = g;
            _p = p;
        }

        public void Build() {
            //----------------以下为画胖小人代码
            //head
            _g.DrawEllipse(new Pen(Color.OrangeRed), 50, 20, 30, 30);

            //body
            _g.FillEllipse(new SolidBrush(Color.SandyBrown), 50, 50, 30, 50);

            //left arm
            _g.TranslateTransform(50, 50);
            _g.RotateTransform(45);
            _g.FillEllipse(new SolidBrush(Color.DarkRed), 0, 0, 10, 40);
            _g.ResetTransform();
            //left arm end

            //right arm
            _g.TranslateTransform(70, 60);
            _g.RotateTransform(290);
            _g.FillEllipse(new SolidBrush(Color.DarkRed), 0, 0, 10, 40);
            _g.ResetTransform();
            //right arm end

            //left leg
            _g.TranslateTransform(60, 100);
            _g.RotateTransform(20);
            _g.FillEllipse(new SolidBrush(Color.Navy), 0, 0, 10, 60);
            _g.ResetTransform();
            //left leg end

            //right leg
            _g.TranslateTransform(65, 100);
            _g.RotateTransform(320);
            _g.FillEllipse(new SolidBrush(Color.Navy), 0, 0, 10, 60);
            _g.ResetTransform();
            //right leg end
            //----------------以上为画胖小人代码
        }
    }
}