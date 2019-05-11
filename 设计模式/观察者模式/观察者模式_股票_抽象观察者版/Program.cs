using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_股票_抽象观察者版 {
    class Program {
        static void Main(string[] args) {
            Stock stock = new Stock() {Symbol = "SINA", Price = 120.35};

            Investor observerA = new Investor {Name = "丁蟹"};
            observerA.SetStock(stock);

            Investor observerB = new Investor {Name = "陈万贤"};
            observerB.SetStock(stock);

            Investor observerC = new Investor {Name = "周济生"};
            observerC.SetStock(stock);

            Phone phoneA = new Phone {PhoneNumber = "13566313313"};
            phoneA.SetStock(stock);

            Phone phoneB = new Phone {PhoneNumber = "18066777766"};
            phoneB.SetStock(stock);

            Phone phoneC = new Phone {PhoneNumber = "18977222277"};
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