using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_端口设备_建造者模式版
{
	internal class InputEquipmentBuilder : EquipmentBuilder
	{
		public InputEquipmentBuilder(string equipmentName)
			: base(equipmentName)
		{
		}

		public override void BuildPort()
		{
			Port inputPort = new InputPort();
			m_equipment.AddPort(inputPort);
		}

		public override void BuildMachine(string machineName)
		{
			base.BuildMachine(machineName);
			m_machine.PortType = "Input";
		}
	}
}