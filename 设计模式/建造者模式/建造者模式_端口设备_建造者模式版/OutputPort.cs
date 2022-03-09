#region

using System;

#endregion

namespace 建造者模式_端口设备_建造者模式版 {
    internal class OutputPort : Port {
        public override void Transfer() {
            Console.WriteLine("Output");
        }
    }
}