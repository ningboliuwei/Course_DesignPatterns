using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_加班_状态模式版
{
	public class Work
	{
		private State _current;

		public Work()
		{
			_current = new MorningState(); //初始化为上午工作状态
		}

		//当前钟点      
		public double Hour { get; set; }

		//是否完成了工作
		public bool TaskFinished { get; set; }

		public void SetState(State s)
		{
			_current = s;
		}

		public void WriteProgram()
		{
			_current.WriteProgram(this);
		}
	}
}