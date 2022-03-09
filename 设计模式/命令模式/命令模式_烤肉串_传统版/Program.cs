#region

using System;

#endregion

namespace 命令模式_烤肉串_传统版 {
    internal class Program {
        private static void Main(string[] args) {
            var chef = new Chef();

            chef.BakeLamp();
            chef.BakeLamp();
            chef.BakeLamp();
            chef.BakeChickenWing();
            chef.BakeLamp();
            chef.BakeLamp();
            chef.BakeChickenWing();

            Console.ReadLine();
        }
    }
}