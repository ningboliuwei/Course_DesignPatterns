#region

using System;

#endregion

namespace 观察者模式_股票_抽象观察者版 {
    internal class Investor : Observer {
        public string Name { get; set; }

        public override void Response() {
            Console.WriteLine($"股民 {Name} 已得知股票 {Stock.Symbol} 的最新价格为 {Stock.Price}");
        }

        public override void SetStock(Stock stock) {
            Stock = stock;
        }
    }
}