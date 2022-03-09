#region

using System;
using 观察者模式_股票_多订阅者版;

#endregion

namespace 观察者模式_股_多订阅者版 {
    internal class Program {
        private static void Main(string[] args) {
            var stock = new Stock { Symbol = "SINA", Price = 120.35 };

            var investorA = new Investor { Name = "丁蟹" };
            investorA.SetStock(stock);

            var investorB = new Investor { Name = "陈万贤" };
            investorB.SetStock(stock);

            var investorC = new Investor { Name = "周济生" };
            investorC.SetStock(stock);

            var phoneA = new Phone { PhoneNumber = "13566313313" };
            phoneA.SetStock(stock);

            var phoneB = new Phone { PhoneNumber = "18066777766" };
            phoneB.SetStock(stock);

            var phoneC = new Phone { PhoneNumber = "18977222277" };
            phoneC.SetStock(stock);

            stock.AddInvestor(investorA);
            stock.AddInvestor(investorB);
            stock.AddInvestor(investorC);

            stock.AddPhone(phoneA);
            stock.AddPhone(phoneB);
            stock.AddPhone(phoneC);

            stock.Notify();

            stock.Price = 134.56;
            stock.Notify();

            stock.Price = 99.27;
            stock.Notify();

            Console.ReadKey();
        }
    }
}