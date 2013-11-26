using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_端口设备_建造者模式版
{
	internal class SimpleLCDFactory
	{
		public static Equipment CreateEquipment(EquipmentBuilder builder, string machineName)
		{
			builder.BuildPort();
			builder.BuildMachine(machineName);
			return builder.GetEquipment();
		}
	}
}