namespace 动物运动会_泛型 {
    public class Cat : Animal {
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