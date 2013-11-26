using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_加班_状态模式版
{
	internal class SleepingState : State
	{
		public override void WriteProgram(Work w)
		{
			Console.WriteLine("当前时间：{0}点 不行了，睡着了", w.Hour);
		}
	}
}