using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_端口设备_建造者模式版
{
	internal class _2Input1OutputEquipmentBuilder : InputEquipmentBuilder
	{
		public _2Input1OutputEquipmentBuilder(string equipmentName)
			: base(equipmentName)
		{
		}

		public override void BuildPort()
		{
			Port inputPort1 = new InputPort();
			Port inputPort2 = new InputPort();
			Port outputPort = new OutputPort();

			m_equipment.AddPort(inputPort1);
			m_equipment.AddPort(inputPort2);
			m_equipment.AddPort(outputPort);
		}

		public override void BuildMachine(string machineName)
		{
			base.BuildMachine(machineName);
			m_machine.PortType = "2Input1Output";
		}
	}
}