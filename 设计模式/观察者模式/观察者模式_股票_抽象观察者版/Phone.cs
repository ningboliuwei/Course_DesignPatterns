using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_股票_抽象观察者版 {
    class Phone : Observer {
        public string PhoneNumber { get; set; }

        public override void SetStock(Stock stock) {
            Stock = stock;
        }

        public override void Response() {
            Console.WriteLine($"手机 {PhoneNumber} 已收到股票 {Stock.Symbol} 的最新价格为 {Stock.Price}");
        }
    }
}