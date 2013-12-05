
using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_加班_状态模式_状态类转换版
{
	internal class AfternoonState : State
	{
		public override void WriteProgram(Work work)
		{
			if (work.Hour < 17)
			{
				Console.WriteLine("当前时间：{0}点 下午状态还不错，继续努力。", work.Hour);
			}
			else
			{
				work.SetState(new EveningState());
				work.WriteProgram();
			}
		}
	}
}