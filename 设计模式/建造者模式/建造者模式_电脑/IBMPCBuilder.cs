#region

using System;

#endregion

namespace 建造者模式_电脑 {
    internal class IBMPCBuilder : PCBuilder {
        public override void BuildCPU() {
            Console.WriteLine("IBM CPU");
        }

        public override void BuildHarddisk() {
            Console.WriteLine("IBM Harddisk");
        }

        public override void BuildKeyboard() {
            Console.WriteLine("IBM Keyboard");
        }

        public override void BuildMonitor() {
            Console.WriteLine("IBM Monitor");
        }

        public override void BuildMouse() {
            Console.WriteLine("IBM Mouse");
        }

        public override void BuildRAM() {
            Console.WriteLine("IBM RAM");
        }
    }
}