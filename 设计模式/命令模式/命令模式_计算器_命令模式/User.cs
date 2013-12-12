using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace 命令模式_计算器_命令模式
{
	internal class User
	{
		private Caculator m_caculator = new Caculator();

		private List<Command> m_commands = new List<Command>();

		private int current = 0;

		public void Redo(int levels)
		{
			Console.WriteLine("---Redo {0} levels", levels);

			for (int i = 0; i < levels; i++)
			{
				if (current < this.m_commands.Count - 1)
				{
					(this.m_commands[current++]).Execute();
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
					(this.m_commands[--current]).UnExecute();
				}
			}
		}

		public void Compute(char optr, int operand)
		{
			Command command = new CaculatorCommand(this.m_caculator, optr, operand);
			command.Execute();

			this.m_commands.Add(command);
			current++;
		}
	}
}