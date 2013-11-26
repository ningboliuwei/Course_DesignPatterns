using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 建造者模式_端口设备_传统版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			//--------------------------以下为创建一个InputOutputMachine
			Machine machine = new Machine("InputOutputMachine");
			machine.PortType = "InputOutput";
			Port inputPort = new InputPort();
			Port outputPort = new OutputPort();
			Equipment equipment = new Equipment();
			equipment.Machine = machine;
			equipment.Name = "InputOutputEquipment";
			equipment.AddPort(inputPort);
			equipment.AddPort(outputPort);
			equipment.Run();
			//--------------------------以上为创建一个InputOutputMachine

			//--------------------------以下为创建一个InputMachine
			//Machine machine = new Machine("InputMachine");
			//machine.PortType = "Input";
			//Port inputPort = new InputPort();
			//Equipment equipment = new Equipment();
			//equipment.Machine = machine;
			//equipment.Name = "InputEquipment";
			//equipment.AddPort(inputPort);
			//equipment.Run();
			//--------------------------以上为创建一个InputMachine

			//--------------------------以下为创建一个OutputMachine
			//Machine machine = new Machine("OutputMachine");
			//machine.PortType = "Output";
			//Port outputPort = new OutputPort();
			//Equipment equipment = new Equipment();
			//equipment.Machine = machine;
			//equipment.Name = "OutputEquipment";
			//equipment.AddPort(outputPort);
			//equipment.Run();
			//--------------------------以上为创建一个OutputMachine

			Console.ReadLine();
		}
	}
}