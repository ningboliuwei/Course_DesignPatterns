#region

using System;

#endregion

namespace 命令模式_烤肉串_松耦合 {
    internal class Chef {
        public void BakeChickenWing() {
            Console.WriteLine("烤鸡翅");
        }

        public void BakeLamp() {
            Console.WriteLine("烤羊肉");
        }
    }
}