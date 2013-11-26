using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式_烤肉串_命令模式
{
	internal class BakeLampCommand : Command
	{
		public BakeLampCommand(Chef receiver)
			: base(receiver)
		{
		}

		public override void ExecuteCommand()
		{
			_receiver.BakeLamp();
		}
	}
}