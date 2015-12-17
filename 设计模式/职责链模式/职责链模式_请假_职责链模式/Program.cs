using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式_请假_职责链模式
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			ProjectManager pm = new ProjectManager("PM");
			DepartmentManager dm = new DepartmentManager("DM");
			GeneralManager gm = new GeneralManager("GM");
			CEOManager ceo = new CEOManager("CEO");

			pm.Superior = dm;
			dm.Superior = gm;
			gm.Superior = ceo;

			Request r1 = new Request("小明", "请假", "表弟结婚", 1);
			pm.HandleRequest(r1);
			Console.WriteLine("-------------------------------------");

			Request r2 = new Request("小明", "请假", "表弟结婚", 4);
			pm.HandleRequest(r2);
			Console.WriteLine("-------------------------------------");

			Request r3 = new Request("小明", "请假", "表弟结婚", 6);
			pm.HandleRequest(r3);
			Console.WriteLine("-------------------------------------");

			Request r4 = new Request("小明", "加薪", "物价上涨太快", 500);
			pm.HandleRequest(r4);
			Console.WriteLine("-------------------------------------");

			Request r5 = new Request("小明", "加薪", "物价上涨太快", 1000);
			pm.HandleRequest(r5);
			Console.WriteLine("-------------------------------------");

			Request r6 = new Request("小明", "请假", "表弟结婚", 15);
			pm.HandleRequest(r6);
			Console.WriteLine("-------------------------------------");

			Console.ReadLine();
		}
	}
}