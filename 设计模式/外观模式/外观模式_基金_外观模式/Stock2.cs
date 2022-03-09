#region

using System;

#endregion

namespace 外观模式_基金_外观模式 {
    internal class Stock2 {
        public void Buy() {
            Console.WriteLine("买入股票2");
        }

        public void Sell() {
            Console.WriteLine("卖出股票2");
        }
    }
}