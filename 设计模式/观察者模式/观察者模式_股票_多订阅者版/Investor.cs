using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_股票_多订阅者版 {
    class Investor {
        public string Name { get; set; }
        public double LowerPrice { get; set; }
        public double UpperPrice { get; set; }
        private Stock _stock;

        public void SetStock(Stock stock) {
            _stock = stock;
        }

        public void Response() {
            Console.WriteLine($"股民 {Name} 已得知股票 {_stock.Symbol} 的最新价格为 {_stock.Price}");
        }
    }
}