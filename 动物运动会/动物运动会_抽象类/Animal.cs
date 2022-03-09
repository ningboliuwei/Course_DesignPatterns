namespace 动物运动会_抽象类 {
    internal abstract class Animal {
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

        // protected virtual string GetShoutSound() {
        //     return "";
        // }

        protected abstract string GetShoutSound();

        public string Shout() {
            var resultStr = "";
            resultStr += "我是" + name + "，";

            for (var i = 0; i < shoutNum; i++) {
                resultStr += GetShoutSound();
            }

            return resultStr;
        }

        //抽象类Animal中的成员被部分实现（抽象类中不是所有的成员都是抽象方法）
    }
}