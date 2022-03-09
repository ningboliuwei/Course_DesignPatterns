#region

using System;
using System.Collections.Generic;

#endregion

namespace 命令模式_烤肉串_命令模式 {
    public class Waiter {
        private readonly List<Command> orders = new List<Command>();

        public void CancelOrder(Command command) {
            orders.Remove(command);
            Console.WriteLine("取消订单：" + command + " 时间：" + DateTime.Now);
        }

        public void Notify() {
            foreach (var command in orders) {
                command.ExecuteCommand();
            }
        }

        public void SetOrder(Command command) {
            //if (command is BakeLampCommand)
            //{
            //	Console.WriteLine("没羊排了");
            //}
            //else
            //{
            orders.Add(command);
            Console.WriteLine("增加订单：" + command + " 时间：" + DateTime.Now);
            //} 
        }
    }
}