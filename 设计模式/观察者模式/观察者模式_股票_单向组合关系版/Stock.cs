namespace 观察者模式_股票_单向组合关系版 {
    internal class Stock : Subject {
        public double Price { get; set; }
        public string Symbol { get; set; }
    }
}