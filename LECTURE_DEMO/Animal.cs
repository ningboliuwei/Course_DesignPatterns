namespace LECTURE_DEMO {
    internal class Animal {
        private readonly string _name = "";

        public Animal(string name) {
            _name = name;
        }

        public Animal() {
            _name = "无名";
        }

        public int ShoutCount { get; set; } = 0;

        public virtual string GetShoutSound() {
            return "*~";
        }

        public string Shout() {
            var shoutSound = GetShoutSound();

            var s = "我是" + _name + ", ";
            for (var i = 0; i < ShoutCount; i++) {
                s += shoutSound;
            }

            return s;
        }
    }
}