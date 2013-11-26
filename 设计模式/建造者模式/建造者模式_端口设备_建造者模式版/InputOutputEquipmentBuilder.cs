using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_端口设备_建造者模式版
{
	internal class InputOutputEquipmentBuilder : EquipmentBuilder
	{
		public InputOutputEquipmentBuilder(string equipmentName)
			: base(equipmentName)
		{
		}

		public override void BuildPort()
		{
			Port inputPort = new InputPort();
			Port outputPort = new OutputPort();
			m_equipment.AddPort(inputPort);
			m_equipment.AddPort(outputPort);
		}

		public override void BuildMachine(string machineName)
		{
			base.BuildMachine(machineName);
			m_machine.PortType = "InputOutputPort";
		}
	}
}