#region

using System;

#endregion

namespace 命令模式_计算器_命令模式 {
    internal class Program {
        private static void Main(string[] args) {
            var user = new User();

            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            user.Undo(4);
            user.Redo(2);

            Console.ReadLine();
        }
    }
}