using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式_自定义功能键_命令队列版
{
	using System.IO;

	class CommandQueue
	{
		private List<Command> m_commands = new List<Command>();

		public void Add(Command command)
		{
			this.m_commands.Add(command);
		}

		public void Remove(Command command)
		{
			this.m_commands.Remove(command);
		}

		public void Execute()
		{
			foreach (Command command in this.m_commands)
			{
				command.Execute();
			}
		}

		//增加日志功能开始
		public void WriteToLog(string filePath)
		{
			StreamWriter writer = new StreamWriter(filePath);
			string content = "";

			foreach (Command command in m_commands)
			{
				content += command.GetType() + Environment.NewLine;
			}
			writer.WriteLine(content);
			writer.Close();
		}
		//增加日志功能结束
	}
}
