using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式_请假_职责链模式
{
	public class Application
	{
		//申请人
		public string Name { get; set; }

		//申请数量
		public int DayCount { get; set; }

		public Application(string name, int number)
		{
			Name = name;
			DayCount = number;
		}
	}
}