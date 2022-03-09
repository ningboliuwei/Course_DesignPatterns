#region

using System;

#endregion

namespace 建造者模式_端口设备_工厂版 {
    internal class Program {
        private static void Main(string[] args) {
            var equipment1 = SimpleLCDFactory.CreateInputEquipment("Equipment1");
            var equipment2 = SimpleLCDFactory.CreateOutputEquipment("Equipment2");
            var equipment3 = SimpleLCDFactory.CreateInputOutputEquipment("Equipment3");
            var equipment4 = SimpleLCDFactory.CreateInputEquipment("Equipment4");

            equipment1.Run();
            equipment2.Run();
            equipment3.Run();
            equipment4.Run();

            Console.ReadLine();
        }
    }
}