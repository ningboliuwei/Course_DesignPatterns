#region

using System;

#endregion

namespace 建造者模式_端口设备_建造者模式版 {
    internal class Program {
        private static void Main(string[] args) {
            var equipment1 = SimpleLCDFactory.CreateEquipment(new InputEquipmentBuilder("Equipment1"), "Input");
            equipment1.Run();

            var equipment2 = SimpleLCDFactory.CreateEquipment(new OutputEquipmentBuilder("Equipment2"), "Output");
            equipment2.Run();

            var equipment3 =
                SimpleLCDFactory.CreateEquipment(new InputOutputEquipmentBuilder("Equipment3"), "InputOutput");
            equipment3.Run();

            var equipment4 = SimpleLCDFactory.CreateEquipment(
                new _2Input1OutputEquipmentBuilder("Equipment4"),
                "2Input1Output");
            equipment4.Run();

            Console.ReadLine();
        }
    }
}