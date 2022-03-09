namespace 动物运动会_泛型 {
    internal class Monkey : Animal {
        public Monkey() {
        }

        public Monkey(string name)
            : base(name) {
        }

        protected override string getShoutSound() {
            return "吱~";
        }
    }
}