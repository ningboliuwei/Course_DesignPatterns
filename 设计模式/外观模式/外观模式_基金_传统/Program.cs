#region

using System;

#endregion

namespace 外观模式_基金_传统 {
    internal class Program {
        private static void Main(string[] args) {
            var s1 = new Stock1();
            var s2 = new Stock2();
            var s3 = new Stock3();

            s1.Buy();
            s2.Buy();
            s3.Buy();

            s1.Sell();
            s2.Sell();
            s3.Sell();

            Console.ReadLine();
        }
    }
}