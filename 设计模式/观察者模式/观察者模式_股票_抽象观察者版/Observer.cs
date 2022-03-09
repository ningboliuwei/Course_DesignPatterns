namespace 观察者模式_股票_抽象观察者版 {
    internal abstract class Observer {
        protected Stock Stock;
        public abstract void Response();

        public abstract void SetStock(Stock stock);
    }
}