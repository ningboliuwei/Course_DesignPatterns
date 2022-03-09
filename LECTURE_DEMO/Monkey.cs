namespace LECTURE_DEMO {
    internal class Monkey : Animal {
        public Monkey(string name) : base(name) {
        }

        public override string GetShoutSound() {
            return "昂~";
        }
    }
}