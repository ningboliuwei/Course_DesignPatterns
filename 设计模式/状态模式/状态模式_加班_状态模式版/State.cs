using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_加班_状态模式版
{
	public abstract class State
	{
		public abstract void WriteProgram(Work w);
	}
}