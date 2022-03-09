#region

using System;

#endregion

namespace 职责链模式_请假_职责链模式 {
    internal class Program {
        private static void Main(string[] args) {
            var tl = new TeamLeader("组长");
            var dm = new DepartmentManager("部门经理");
            var gm = new GeneralManager("总经理");

            tl.SetSuperior(dm);
            dm.SetSuperior(gm);

            var a1 = new Application("小明", 1);
            tl.HandleApplications(a1);

            var a2 = new Application("小明", 4);
            tl.HandleApplications(a2);

            var a3 = new Application("小明", 12);
            tl.HandleApplications(a3);

            var a4 = new Application("小明", 31);
            tl.HandleApplications(a4);

            Console.ReadLine();
        }
    }
}