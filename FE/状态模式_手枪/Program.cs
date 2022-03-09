#region

using System;

#endregion

namespace 状态模式_手枪 {
    internal class Program {
        private static void Main(string[] args) {
            var pistol = new Pistol();

            pistol.Reload();
            pistol.Fire();
            pistol.Fire();
            pistol.Fire();
            pistol.Fire();
            pistol.Reload();

            Console.ReadLine();
        }
    }
}