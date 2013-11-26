using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式_烤肉串_命令模式_合成
{
	internal class CommandCombineAll : CommandCombine
	{
		public CommandCombineAll(Chef chef)
			: base(chef)
		{
		}

		public override void BakeLampCommand()
		{
			_chef.BakeLamp();
		}

		public override void BackChickenWingCommand()
		{
			_chef.BakeChickenWing();
		}
	}
}