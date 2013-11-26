﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式_烤肉串_松耦合
{
	internal class BakeLampCommand : Command
	{
		public BakeLampCommand(Chef chef)
			: base(chef)
		{
		}

		public override void ExecuteCommand()
		{
			_chef.BakeLamp();
		}
	}
}