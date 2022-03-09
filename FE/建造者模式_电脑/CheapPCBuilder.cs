#region

using System;

#endregion

namespace 建造者模式_电脑 {
    internal class CheapPCBuilder : PCBuilder {
        public override void BuildDesktop() {
            Console.WriteLine("Dell Desktop");
        }

        public override void BuildMonitor() {
            Console.WriteLine("AOC Monitor");
        }

        public override void BuildPeripherals() {
            Console.WriteLine("Logitech Peripherals");
        }
    }
}