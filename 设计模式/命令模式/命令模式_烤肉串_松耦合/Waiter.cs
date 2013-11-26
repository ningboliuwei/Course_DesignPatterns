using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式_烤肉串_松耦合
{
	internal class Waiter
	{
		private Command _command;

		public void SetOrder(Command command)
		{
			_command = command;
		}

		public void Notify()
		{
			_command.ExecuteCommand();
		}
	}
}