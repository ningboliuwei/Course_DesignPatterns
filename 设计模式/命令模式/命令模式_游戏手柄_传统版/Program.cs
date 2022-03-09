#region

using System;

#endregion

namespace 命令模式_游戏手柄_传统版 {
    internal class Program {
        private static void Main(string[] args) {
            var key = Console.ReadLine();

            if (key == "A") {
                Console.WriteLine("地面传球");
            }
            else if (key == "B") {
                Console.WriteLine("空中传球");
            }
            else if (key == "X") {
                Console.WriteLine("射门");
            }
            else if (key == "Y") {
                Console.WriteLine("直传球");
            }

            Console.ReadLine();
        }
    }
}