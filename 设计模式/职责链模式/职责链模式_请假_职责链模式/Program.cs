using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式_请假_职责链模式
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			CommonManager cm = new CommonManager("CM");
			MajorManager mm = new MajorManager("MM");
			GeneralManager gm = new GeneralManager("GM");
			CEOManager em = new CEOManager("EM");

			cm.SetSuperior(em);
			cm.SetSuperior(em);

			//cm.SetSuperior(mm);
			// mm.SetSuperior(gm);
			//gm.SetSuperior(em);

			Request r1 = new Request("小明", "请假", "表弟结婚", 1);
			cm.RequestApplications(r1);

			Request r2 = new Request("小明", "请假", "表弟结婚", 4);
			cm.RequestApplications(r2);

			Request r3 = new Request("小明", "请假", "表弟结婚", 6);
			cm.RequestApplications(r3);

			Request r4 = new Request("小明", "加薪", "物价上涨太快", 500);
			cm.RequestApplications(r4);

			Request r5 = new Request("小明", "加薪", "物价上涨太快", 1000);
			cm.RequestApplications(r5);

			Console.ReadLine();
		}
	}
}