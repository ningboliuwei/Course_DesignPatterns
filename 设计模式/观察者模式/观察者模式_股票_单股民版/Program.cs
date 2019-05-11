using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_股票_单股民版
{
    class Program
    {
        static void Main(string[] args) {
            Stock stock = new Stock {Symbol = "SINA", Price = 120.35};
            Investor investor = new Investor {Name = "丁蟹", LowerPrice = 100, UpperPrice = 130};
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