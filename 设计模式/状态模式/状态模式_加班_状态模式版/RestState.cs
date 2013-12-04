﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_加班_状态模式版
{
	internal class RestState : State
	{
		public override void WriteProgram(Work work)
		{
			Console.WriteLine("当前时间{0}点 下班回家了", work.Hour);
		}
	}
}