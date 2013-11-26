using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式_请假_职责链模式
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			TeamLeader tl = new TeamLeader("组长");
			DepartmentManager dm = new DepartmentManager("部门经理");
			GeneralManager gm = new GeneralManager("总经理");

			tl.SetSuperior(dm);
			dm.SetSuperior(gm);

			Application a1 = new Application("小明", 1);
			tl.HandleApplications(a1);

			Application a2 = new Application("小明", 4);
			tl.HandleApplications(a2);

			Application a3 = new Application("小明", 12);
			tl.HandleApplications(a3);

			Application a4 = new Application("小明", 31);
			tl.HandleApplications(a4);

			Console.ReadLine();
		}
	}
}