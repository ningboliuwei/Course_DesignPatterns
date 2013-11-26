using System;
using System.Collections.Generic;
using System.Text;

namespace 策略模式_计算器_满送_策略
{
	internal class CashContext
	{
		private CashSuper m_cs = null;

		public CashContext(CashSuper cssuper)
		{
			m_cs = cssuper;
		}

		public double GetResult(double money)
		{
			return m_cs.AcceptCash(money);
		}
	}
}