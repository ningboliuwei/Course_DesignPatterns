#region

using System;

#endregion

namespace 观察者模式_股票_抽象观察者版 {
    internal class Program {
        private static void Main(string[] args) {
            var stock = new Stock { Symbol = "SINA", Price = 120.35 };

            var observerA = new Investor { Name = "丁蟹" };
            observerA.SetStock(stock);

            var observerB = new Investor { Name = "陈万贤" };
            observerB.SetStock(stock);

            var observerC = new Investor { Name = "周济生" };
            observerC.SetStock(stock);

            var phoneA = new Phone { PhoneNumber = "13566313313" };
            phoneA.SetStock(stock);

            var phoneB = new Phone { PhoneNumber = "18066777766" };
            phoneB.SetStock(stock);

            var phoneC = new Phone { PhoneNumber = "18977222277" };
            phoneC.SetStock(stock);

            stock.AddObserver(observerA);
            stock.AddObserver(observerB);
            stock.AddObserver(observerC);

            stock.AddObserver(phoneA);
            stock.AddObserver(phoneB);
            stock.AddObserver(phoneC);

            stock.Notify();

            stock.Price = 134.56;
            stock.Notify();

            stock.Price = 99.27;
            stock.Notify();

            Console.ReadKey();
        }
    }
}