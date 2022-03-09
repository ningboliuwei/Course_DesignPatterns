#region

using System;

#endregion

namespace 观察者模式_股票_多订阅者版 {
    internal class Investor {
        private Stock _stock;
        public double LowerPrice { get; set; }
        public string Name { get; set; }
        public double UpperPrice { get; set; }

        public void Response() {
            Console.WriteLine($"股民 {Name} 已得知股票 {_stock.Symbol} 的最新价格为 {_stock.Price}");
        }

        public void SetStock(Stock stock) {
            _stock = stock;
        }
    }
}