#region

using System;

#endregion

namespace 建造者模式_端口设备_工厂版 {
    public class Machine {
        public Machine(string machineName) {
            Name = machineName;
        }

        public string Name { get; set; }
        public string PortType { get; set; }

        public void Run() {
            Console.WriteLine("The machine {0} is running, the port type is {1}", Name, PortType);
        }
    }
}