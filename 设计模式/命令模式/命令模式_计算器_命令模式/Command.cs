using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式_计算器_命令模式
{
	public abstract class Command
	{
		public abstract void Execute();

		public abstract void UnExecute();
	}
}