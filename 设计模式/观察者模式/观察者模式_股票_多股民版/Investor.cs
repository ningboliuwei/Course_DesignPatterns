using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_股票_多股民版 {
    class Investor {
        public string Name { get; set; }
        public double LowerPrice { get; set; }
        public double UpperPrice { get; set; }
        private Stock _stock;

        public void SetStock(Stock stock) {
            _stock = stock;
        }

        public void Response() {
            Console.Write($"{Name} 已得知股票 {_stock.Symbol} 的最新价格为 {_stock.Price}，");

            if (_stock.Price >= UpperPrice) {
                Console.WriteLine("进行卖出操作");
            }
            else if (_stock.Price <= LowerPrice) {
                Console.WriteLine("进行买入操作");
            }
            else {
                Console.WriteLine("不进行任何操作");
            }
        }
    }
}