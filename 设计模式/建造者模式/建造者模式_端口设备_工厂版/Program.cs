using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 建造者模式_端口设备_工厂版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Equipment equipment1 = SimpleLCDFactory.CreateInputEquipment("Equipment1");
			Equipment equipment2 = SimpleLCDFactory.CreateOutputEquipment("Equipment2");
			Equipment equipment3 = SimpleLCDFactory.CreateInputOutputEquipment("Equipment3");
			Equipment equipment4 = SimpleLCDFactory.CreateInputEquipment("Equipment4");

			equipment1.Run();
			equipment2.Run();
			equipment3.Run();
			equipment4.Run();

			Console.ReadLine();
		}
	}
}