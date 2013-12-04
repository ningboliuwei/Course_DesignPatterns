using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_加班_状态模式版
{
	public class Work
	{
		private State m_currentState;

		public Work()
		{
			this.SetState(new MorningState());
		}

		//当前钟点      
		public double Hour { get; set; }

		//是否完成了工作
		public bool TaskFinished { get; set; }

		public void SetState(State state)
		{
			this.m_currentState = state;
		}

		public void WriteProgram()
		{
			m_currentState.WriteProgram(this);
		}
	}
}