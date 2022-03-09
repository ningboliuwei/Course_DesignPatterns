namespace 观察者模式_股票_抽象观察对象版 {
    internal class Stock : Subject {
        public double Price { get; set; }
        public string Symbol { get; set; }
    }
}