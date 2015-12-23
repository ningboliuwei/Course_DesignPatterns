using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_股票_单股民版
{
    class Investor
    {
        public string Name { get; set; }
        public Stock Stock { get; set; }

        public void Update()
        {
            Console.WriteLine($"{Name} 已得知股票 {Stock.Symbol} 的最新价格为 {Stock.Price}");
        }
    }
}
