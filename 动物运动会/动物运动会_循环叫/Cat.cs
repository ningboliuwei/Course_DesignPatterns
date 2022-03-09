namespace 动物运动会_循环叫 {
    public class Cat {
        private readonly string name = "";
        private int shoutNum = 0;

        public Cat(string name) {
            this.name = name;
        }

        public Cat() {
            name = "无名";
        }

        public int ShoutNum { get; set; } = 3;
        // public int ShoutNum {
        //     get { return shoutNum; }
        //     set { shoutNum = value; }
        // }

        public string Shout() {
            var resultStr = "";
            resultStr += "我是" + name + ", ";

            for (var i = 0; i < ShoutNum; i++) {
                resultStr += "喵~";
            }

            return resultStr;
        }
    }
}