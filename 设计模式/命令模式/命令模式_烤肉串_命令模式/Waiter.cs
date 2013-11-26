using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式_烤肉串_命令模式
{
	public class Waiter
	{
		private List<Command> orders = new List<Command>();

		public void SetOrder(Command command)
		{
			//if (command is BakeLampCommand)
			//{
			//	Console.WriteLine("没羊排了");
			//}
			//else
			//{
			orders.Add(command);
			Console.WriteLine("增加订单：" + command.ToString() + " 时间：" + DateTime.Now.ToString());
			//} 
		}

		public void CancelOrder(Command command)
		{
			orders.Remove(command);
			Console.WriteLine("取消订单：" + command.ToString() + " 时间：" + DateTime.Now.ToString());
		}

		public void Notify()
		{
			foreach (Command command in orders)
			{
				command.ExecuteCommand();
			}
		}
	}
}