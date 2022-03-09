#region

using System;
using System.Collections.Generic;

#endregion

namespace 建造者模式_端口设备_建造者模式版 {
    public class Equipment {
        public Equipment() {
            Ports = new List<Port>();
        }

        public Machine Machine { get; set; }
        public string Name { get; set; }

        public List<Port> Ports { get; set; }

        public void AddPort(Port port) {
            Ports.Add(port);
        }

        public void RemovePort(Port port) {
            Ports.Remove(port);
        }

        public void Run() {
            Console.WriteLine("The Equipment {0} is running as below...", Name);
            foreach (var port in Ports) {
                port.Transfer();
            }

            Machine.Run();
        }
    }
}