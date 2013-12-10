using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式_自定义功能键_命令模式版
{
	class MinimizeCommand : Command
	{
		private MinimizeHandler minimizeHandler;

		public MinimizeCommand()
		{
			minimizeHandler = new MinimizeHandler();
		}
		public override void Execute()
		{
			minimizeHandler.Minimize();
		}
	}
}
