#region

using System;

#endregion

namespace 外观模式_基金_传统 {
    internal class Stock1 {
        public void Buy() {
            Console.WriteLine("买入股票1");
        }

        public void Sell() {
            Console.WriteLine("卖出股票1");
        }
    }
}