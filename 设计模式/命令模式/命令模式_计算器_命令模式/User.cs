using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace 命令模式_计算器_命令模式
{
	internal class User
	{
		private Caculator _caculator = new Caculator();

		private List<Command> commands = new List<Command>();

		private int current = 0;

		public void Redo(int levels)
		{
			Console.WriteLine("---Redo {0} levels", levels);

			for (int i = 0; i < levels; i++)
			{
				if (current < commands.Count - 1)
				{
					(commands[current++]).Execute();
				}
			}
		}

		public void Undo(int levels)
		{
			Console.WriteLine("---Undo {0} levels", levels);

			for (int i = 0; i < levels; i++)
			{
				if (current > 0)
				{
					(commands[--current]).UnExecute();
				}
			}
		}

		public void Compute(char optr, int operand)
		{
			Command command = new CaculatorCommand(_caculator, optr, operand);
			command.Execute();

			commands.Add(command);
			current++;
		}
	}
}