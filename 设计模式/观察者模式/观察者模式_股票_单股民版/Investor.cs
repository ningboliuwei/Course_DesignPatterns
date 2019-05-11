using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;

namespace 观察者模式_股票_单股民版
{
    class Investor
    {
        public string Name { get; set; }
        private Stock _stock;

        public void SetStock(Stock stock)
        {
            _stock = stock;
        }

        public void Response()
        {
            Console.Write($"{Name} 已得知股票 {_stock.Symbol} 的最新价格为 {_stock.Price}，");

            if (_stock.Price > 130)
            {
                Console.WriteLine("进行卖出操作");
            }
            else if (_stock.Price < 100)
            {
                Console.WriteLine("进行卖出操作");
            }
            else
            {
                Console.WriteLine("不进行任何操作");
            }
        }
    }
}