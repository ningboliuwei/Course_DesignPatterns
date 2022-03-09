#region

using System.Drawing;
using 装饰模式_小人_画图版;

#endregion

namespace 装饰模式 {
    internal class Finery : Person {
        protected Person _person;

        public Finery() {
        }

        public Finery(Graphics g, Pen p)
            : base(g, p) {
        }

        public void Decorate(Person person) {
            _person = person;
        }

        public override void Show() {
            if (_person != null) {
                _person.Show();
            }
        }
    }
}