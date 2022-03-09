using System.Drawing;

namespace 建造者模式_画小人_建造者模式版 {
    public abstract class PersonBuilder {
        protected Graphics _g;

        protected Pen _p;

        public PersonBuilder (Graphics g, Pen p) {
            _g = g;
            _p = p;
        }

        public abstract void BuildHead ();

        public abstract void BuildBody ();

        public abstract void BuildLeftArm ();

        public abstract void BuildRightArm ();

        public abstract void BuildLeftLeg ();

        public abstract void BuildRightLeg ();
    }
}