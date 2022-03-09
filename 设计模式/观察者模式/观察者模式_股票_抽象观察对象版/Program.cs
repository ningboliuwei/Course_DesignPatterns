#region

using System;

#endregion

namespace 观察者模式_股票_抽象观察对象版 {
    internal class Program {
        private static void Main(string[] args) {
            var stock = new Stock { Symbol = "SINA", Price = 120.35 };
            var bond = new Bond { Company = "BAIDU", Price = 90.42 };

            var observerA = new Investor { Name = "丁蟹" };
            observerA.SetSubject(stock);

            var observerB = new Investor { Name = "陈万贤" };
            observerB.SetSubject(bond);

            var observerC = new Investor { Name = "周济生" };
            observerC.SetSubject(bond);

            var phoneA = new Phone { PhoneNumber = "13566313313" };
            phoneA.SetSubject(stock);

            var phoneB = new Phone { PhoneNumber = "18066777766" };
            phoneB.SetSubject(bond);

            var phoneC = new Phone { PhoneNumber = "18977222277" };
            phoneC.SetSubject(bond);

            stock.AddObserver(observerA);
            bond.AddObserver(observerB);
            bond.AddObserver(observerC);

            stock.AddObserver(phoneA);
            bond.AddObserver(phoneB);
            bond.AddObserver(phoneC);

            stock.Notify();
            bond.Notify();

            stock.Price = 134.56;
            stock.Notify();
            bond.Notify();

            stock.Price = 99.27;
            stock.Notify();
            bond.Notify();

            Console.ReadKey();
        }
    }
}