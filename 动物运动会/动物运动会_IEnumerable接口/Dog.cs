namespace 动物运动会_泛型 {
    public class Dog : Animal {
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