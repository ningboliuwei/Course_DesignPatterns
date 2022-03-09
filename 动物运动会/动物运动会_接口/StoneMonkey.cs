#region

using 动物运动会_接口;

#endregion

namespace 动物运动会 {
    internal class StoneMonkey : Monkey, IChange, IFly {
        public StoneMonkey() {
        }

        public StoneMonkey(string name)
            : base(name) {
        }

        public string ChangeThing(string thing) {
            return Shout() + "我会七十二变，我变出了" + thing;
        }

        public string Fly() {
            return "我正在用筋斗云飞";
        }
    }
}