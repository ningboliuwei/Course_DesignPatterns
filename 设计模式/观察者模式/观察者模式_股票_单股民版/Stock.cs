namespace 观察者模式_股票_单股民版 {
    internal class Stock {
        private Investor _investor;
        public double Price { get; set; }
        public string Symbol { get; set; }

        public void Notify() {
            _investor.Response();
        }

        public void SetInvestor(Investor investor) {
            _investor = investor;
        }
    }
}