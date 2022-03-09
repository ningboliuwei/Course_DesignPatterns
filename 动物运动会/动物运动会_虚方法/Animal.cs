namespace 动物运动会_虚方法 {
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

        //此处若不加 virtual 关键字会如何？
        public virtual string Shout() {
            return "";
        }
    }
}