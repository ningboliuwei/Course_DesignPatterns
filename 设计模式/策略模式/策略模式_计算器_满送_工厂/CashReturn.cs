using System;
using System.Collections.Generic;
using System.Text;

namespace 策略模式_计算器_满送_工厂
{
	internal class CashReturn : CashSuper
	{
		private double moneyCondition = 0.0;

		private double moneyReturn = 0.0;

		public CashReturn(string moneyCondition, string moneyReturn)
		{
			this.moneyCondition = double.Parse(moneyCondition);
			this.moneyReturn = double.Parse(moneyReturn);
		}

		public override double AcceptCash(double money)
		{
			double result = money;
			if (money >= moneyCondition)
			{
				result = money - Math.Floor(money / moneyCondition) * moneyReturn;
			}
			return result;
		}
	}
}