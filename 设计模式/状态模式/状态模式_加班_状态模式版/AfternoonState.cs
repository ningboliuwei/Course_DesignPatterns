using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_加班_状态模式版
{
	internal class AfternoonState : State
	{
		public override void WriteProgram(Work w)
		{
			if (w.Hour < 17)
			{
				Console.WriteLine("当前时间：{0}点 下午状态还不错，继续努力。", w.Hour);
			}
			else
			{
				w.SetState(new EveningState());
				w.WriteProgram();
			}
		}
	}
}