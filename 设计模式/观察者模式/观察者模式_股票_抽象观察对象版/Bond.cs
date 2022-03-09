namespace 观察者模式_股票_抽象观察对象版 {
    internal class Bond : Subject {
        public string Company { get; set; }
        public double Price { get; set; }
    }
}