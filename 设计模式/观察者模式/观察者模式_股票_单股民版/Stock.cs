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

        private Investor _investor;

        public void SetInvestor(Investor investor)
        {
            _investor = investor;
        }

        public void Notify()
        {
            _investor.Update();
        }
    }
}