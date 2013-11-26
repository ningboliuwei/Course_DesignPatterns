using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式_烤肉串_命令模式
{
	public abstract class Command
	{
		protected Chef _receiver;

		public Command(Chef receiver)
		{
			_receiver = receiver;
		}

		public abstract void ExecuteCommand();
	}
}