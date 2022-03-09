namespace 动物运动会_继承 {
    internal class Cat : Animal {
        public Cat() {
        }

        public Cat(string name)
            : base(name) {
        }

        public string Shout() {
            var resultStr = "";
            resultStr += "我是" + name + ", ";

            for (var i = 0; i < shoutNum; i++) {
                resultStr += "喵~";
            }

            return resultStr;
        }
    }
}