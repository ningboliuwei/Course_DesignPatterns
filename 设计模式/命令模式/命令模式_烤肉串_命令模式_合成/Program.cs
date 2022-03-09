#region

using System;

#endregion

namespace 命令模式_烤肉串_命令模式_合成 {
    internal class Program {
        private static void Main(string[] args) {
            var chef = new Chef();
            var combineAll = new CommandCombineAll(chef);

            combineAll.BackChickenWingCommand();
            combineAll.BakeLampCommand();
            Console.ReadLine(); //考虑调料？
        }
    }
}