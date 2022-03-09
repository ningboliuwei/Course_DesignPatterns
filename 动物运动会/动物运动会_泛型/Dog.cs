namespace 动物运动会_泛型 {
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