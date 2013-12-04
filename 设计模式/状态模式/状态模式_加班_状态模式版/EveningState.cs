using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_加班_状态模式版
{
	internal class EveningState : State
	{
		public override void WriteProgram(Work work)
		{
			if (work.TaskFinished)
			{
				work.SetState(new RestState());
				work.WriteProgram();
			}
			else
			{
				if (work.Hour < 21)
				{
					Console.WriteLine("当前时间{0}点 加班哦，疲劳之极", work.Hour);
				}
				else
				{
					work.SetState(new SleepingState());
					work.WriteProgram();
				}
			}
		}
	}
}