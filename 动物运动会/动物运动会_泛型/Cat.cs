namespace 动物运动会_泛型 {
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