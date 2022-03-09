namespace 动物运动会_虚方法 {
    internal class Dog : Animal {
        public Dog() {
        }

        public Dog(string name)
            : base(name) {
        }

        public override string Shout() {
            var resultStr = "";
            resultStr += "我是" + name + "，";

            for (var i = 0; i < shoutNum; i++) {
                resultStr += "汪~";
            }

            return resultStr;
        }
    }
}