namespace 动物运动会_虚方法改进 {
    public class Animal {
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

        protected virtual string GetShoutSound() {
            return "";
        }

        public string Shout() {
            var resultStr = "";
            resultStr += "我是" + name + "，";

            for (var i = 0; i < shoutNum; i++) {
                resultStr += GetShoutSound();
            }

            return resultStr;
        }
    }
}