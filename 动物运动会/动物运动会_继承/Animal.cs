namespace 动物运动会_继承 {
    internal class Animal {
        protected string name = "";

        protected int shoutNum = 3;

        public Animal(string name) {
            this.name = name;
        }

        public Animal() {
            name = "匿名";
        }

        public int ShoutNum {
            get => shoutNum;

            set => shoutNum = value;
        }
    }
}