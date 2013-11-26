using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_加班_状态模式版
{
	internal class EveningState : State
	{
		public override void WriteProgram(Work w)
		{
			if (w.TaskFinished)
			{
				w.SetState(new RestState());
				w.WriteProgram();
			}
			else
			{
				if (w.Hour < 21)
				{
					Console.WriteLine("当前时间{0}点 加班哦，疲劳之极", w.Hour);
				}
				else
				{
					w.SetState(new SleepingState());
					w.WriteProgram();
				}
			}
		}
	}
}