namespace 动物运动会_接口 {
    internal class Dog : Animal {
        public Dog() {
        }

        public Dog(string name)
            : base(name) {
        }

        protected override string getShoutSound() {
            return "汪~";
        }
    }
}