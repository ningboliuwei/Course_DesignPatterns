using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式_计算器_满送_策略和工厂_反射
{
	internal class CashCredit : CashSuper
	{
		private double m_credit = 0;

		public CashCredit(string credit)
		{
			m_credit = Convert.ToDouble(credit);
		}

		public override double AcceptCash(double money)
		{
			return money - m_credit / 100;
		}
	}
}