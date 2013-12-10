using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式_自定义功能键_命令模式版
{
	class HelperCommand : Command
	{
		private HelpHandler helpHandler;

		public HelperCommand()
		{
			helpHandler = new HelpHandler();
		}
		public override void Execute()
		{

			helpHandler.Display();
		}
	}
}
