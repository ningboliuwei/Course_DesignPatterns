#region

using System;

#endregion

namespace 状态模式_共享状态_开关_多私有成员版 {
    internal class Program {
        private static void Main(string[] args) {
            var s1 = new Switch { Name = "厨房的开关" };
            var s2 = new Switch { Name = "客厅的开关" };

            s1.Press();
            s1.Press();
            s1.Press();
            Console.WriteLine("-----------------------");
            s2.Press();
            s2.Press();
            s2.Press();

            Console.ReadKey();
        }
    }
}