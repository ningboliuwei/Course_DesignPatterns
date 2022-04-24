#region

using 动物运动会_接口;

#endregion

namespace 动物运动会 {
    internal class MachineCat : Cat, IChange, IFly {
        public MachineCat() {
        }

        public MachineCat(string name)
            : base(name) {
        }

        // public string ChangeThing(string thing) {
        //     return Shout() + "我有异次元口袋，我变出了" + thing;
        // }

        public string Fly() {
            return "我正在用竹蜻蜓飞";
        }

        //public string FastFly()
        //{
        //	return "我正在用火箭飞";
        //}
    }
}