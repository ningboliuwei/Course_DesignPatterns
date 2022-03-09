#region

using System;

#endregion

namespace 外观模式_基金_外观模式 {
    internal class House {
        public void Buy() {
            Console.WriteLine("买入房产");
        }

        public void Rent() {
            Console.WriteLine("出租房产");
        }

        public void Sell() {
            Console.WriteLine("卖出房产");
        }
    }
}