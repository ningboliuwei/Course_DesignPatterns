using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式_自定义功能键_命令队列版
{
	class CommandQueue
	{
		private List<Command> commands = new List<Command>();

		public void Add(Command command)
		{
			commands.Add(command);
		}

		public void Remove(Command command)
		{
			commands.Remove(command);
		}

		public void Execute()
		{
			foreach (Command command in commands)
			{
				command.Execute();
			}
		}
	}
}
