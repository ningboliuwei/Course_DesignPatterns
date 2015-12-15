using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_加班_状态模式_状态类转换版
{
	internal class NoonState : State
	{
		public override void Coding(Work work)
		{
			if (work.Hour < 13)
			{
				Console.WriteLine("当前时间：{0}点 饿了，午饭；犯困，午休。", work.Hour);
			}
			else
			{
				work.SetState(new AfternoonState());
				work.Coding();
			}
		}
	}
}