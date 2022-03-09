namespace 动物运动会_ArrayList {
    internal class Cat : Animal {
        public Cat() {
        }

        public Cat(string name)
            : base(name) {
        }

        protected override string getShoutSound() {
            return "喵~";
        }
    }
}