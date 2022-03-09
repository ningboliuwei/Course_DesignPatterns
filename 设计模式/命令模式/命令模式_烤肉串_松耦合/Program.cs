#region

using System;

#endregion

namespace 命令模式_烤肉串_松耦合 {
    internal class Program {
        private static void Main(string[] args) {
            var chef = new Chef();
            Command command1 = new BakeLampCommand(chef);
            Command command2 = new BakeLampCommand(chef);
            Command command3 = new BakeChickenWingCommand(chef);

            var waiter = new Waiter();
            waiter.SetOrder(command1);
            waiter.Notify();

            waiter.SetOrder(command2);
            waiter.Notify();

            waiter.SetOrder(command3);
            waiter.Notify();

            Console.ReadLine(); //考虑调料？
        }
    }
}