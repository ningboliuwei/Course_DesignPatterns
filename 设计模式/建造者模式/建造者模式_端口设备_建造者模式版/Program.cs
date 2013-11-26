using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_端口设备_建造者模式版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Equipment equipment1 = SimpleLCDFactory.CreateEquipment(new InputEquipmentBuilder("Equipment1"), "Input");
			equipment1.Run();

			Equipment equipment2 = SimpleLCDFactory.CreateEquipment(new OutputEquipmentBuilder("Equipment2"), "Output");
			equipment2.Run();

			Equipment equipment3 = SimpleLCDFactory.CreateEquipment(new InputOutputEquipmentBuilder("Equipment3"), "InputOutput");
			equipment3.Run();

			Equipment equipment4 = SimpleLCDFactory.CreateEquipment(
				new _2Input1OutputEquipmentBuilder("Equipment4"),
				"2Input1Output");
			equipment4.Run();

			Console.ReadLine();
		}
	}
}