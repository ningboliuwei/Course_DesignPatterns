using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_股票_抽象观察对象版
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock() {Symbol = "SINA", Price = 120.35};
            Bond bond = new Bond() {Company = "BAIDU", Price = 90.42};

            Investor observerA = new Investor {Name = "丁蟹"};
            observerA.SetSubject(stock);

            Investor observerB = new Investor {Name = "陈万贤"};
            observerB.SetSubject(bond);

            Investor observerC = new Investor {Name = "周济生"};
            observerC.SetSubject(bond);

            Phone phoneA = new Phone {PhoneNumber = "13566313313"};
            phoneA.SetSubject(stock);

            Phone phoneB = new Phone {PhoneNumber = "18066777766"};
            phoneB.SetSubject(bond);

            Phone phoneC = new Phone {PhoneNumber = "18977222277"};
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