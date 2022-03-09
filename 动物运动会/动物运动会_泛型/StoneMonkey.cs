namespace 动物运动会_泛型 {
    internal class StoneMonkey : Monkey, IChange {
        public StoneMonkey() {
        }

        public StoneMonkey(string name)
            : base(name) {
        }

        public string ChangeThing(string thing) {
            return Shout() + "我会七十二变，我变出了" + thing;
        }
    }
}