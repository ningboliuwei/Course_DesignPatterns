namespace 动物运动会_抽象类 {
    internal class Dog : Animal {
        public Dog() {
        }

        public Dog(string name)
            : base(name) {
        }

        protected override string GetShoutSound() {
            return "汪~";
        }
    }
}