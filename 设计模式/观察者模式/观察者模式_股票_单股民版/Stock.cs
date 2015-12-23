using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_股票_单股民版
{
    class Stock
    {
        public string Symbol { get; set; }
        public double Price { get; set; }
        public Investor Investor { get; set; }

        public void Notify()
        {
            Investor.Update();
        }
    }
}
