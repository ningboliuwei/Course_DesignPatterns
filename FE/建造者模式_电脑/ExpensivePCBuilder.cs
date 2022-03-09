#region

using System;

#endregion

namespace 建造者模式_电脑 {
    internal class ExpensivePCBuilder : PCBuilder {
        public override void BuildDesktop() {
            Console.WriteLine("Alien Desktop");
        }

        public override void BuildMonitor() {
            Console.WriteLine("Sony Monitor");
        }

        public override void BuildPeripherals() {
            Console.WriteLine("Razer Peripherals");
        }
    }
}