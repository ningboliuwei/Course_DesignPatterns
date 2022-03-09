namespace 动物运动会_有名字 {
    internal class Cat {
        private readonly string name = "";

        public Cat(string name) {
            this.name = name;
        }

        public Cat() {
            name = "无名";
        }

        public string Shout() {
            return "我是" + name + ", 喵~";
        }
    }
}