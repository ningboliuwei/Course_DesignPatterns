#region

using System;

#endregion

namespace 观察者模式_股票_单股民版 {
    internal class Program {
        private static void Main(string[] args) {
            var stock = new Stock { Symbol = "SINA", Price = 120.35 };
            var investor = new Investor { Name = "丁蟹", LowerPrice = 100, UpperPrice = 130 };
            investor.SetStock(stock);
            stock.SetInvestor(investor);

            stock.Notify();

            stock.Price = 134.56;
            stock.Notify();

            stock.Price = 99.27;
            stock.Notify();

            Console.ReadKey();
        }
    }
}