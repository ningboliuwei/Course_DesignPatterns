using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式_自定义功能键_命令模式版
{
	class FunctionButton
	{
		public string Name { get; set; }
		private Command m_command;

		public FunctionButton(string name)
		{
			Name = name;
		}

		public void SetCommand(Command command)
		{
			m_command = command;
		}

		public void Click()
		{
			m_command.Execute();
		}
	}
}
