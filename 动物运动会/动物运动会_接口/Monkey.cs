#region

using 动物运动会_接口;

#endregion

namespace 动物运动会 {
    internal class Monkey : Animal {
        public Monkey() {
        }

        public Monkey(string name)
            : base(name) {
        }

        protected override string getShoutSound() {
            return "吱~";
        }
    }
}