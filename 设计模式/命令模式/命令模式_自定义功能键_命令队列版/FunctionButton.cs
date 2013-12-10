using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式_自定义功能键_命令队列版
{
	class FunctionButton
	{
		public string Name { get; set; }
		private CommandQueue m_commandQueue = new CommandQueue();

		public FunctionButton(string name)
		{
			
			Name = name;
		}

		public void AddCommand(Command command)
		{
			m_commandQueue.Add(command);
		}

		public void RemoveCommand(Command command)
		{
			m_commandQueue.Remove(command);
		}

		public void Click()
		{
			m_commandQueue.Execute();
		}
	}
}
