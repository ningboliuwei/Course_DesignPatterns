namespace 动物运动会_抽象类 {
    internal class Cat : Animal {
        public Cat() {
        }

        public Cat(string name)
            : base(name) {
        }

        protected override string GetShoutSound() {
            return "喵~";
        }
    }
}