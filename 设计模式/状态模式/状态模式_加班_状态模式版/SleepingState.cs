using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_加班_状态模式_状态类转换版
{
	internal class SleepingState : State
	{
		public override void WriteProgram(Work work)
		{
			Console.WriteLine("当前时间：{0}点 不行了，睡着了", work.Hour);
		}
	}
}