#region

using System;

#endregion

namespace 观察者模式_股票_多订阅者版 {
    internal class Phone {
        private Stock _stock;
        public string PhoneNumber { get; set; }

        public void Response() {
            Console.WriteLine($"手机 {PhoneNumber} 已收到股票 {_stock.Symbol} 的最新价格为 {_stock.Price}");
        }

        public void SetStock(Stock stock) {
            _stock = stock;
        }
    }
}