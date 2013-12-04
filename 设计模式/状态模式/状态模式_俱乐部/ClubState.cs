using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_俱乐部
{
	internal abstract class ClubState
	{
		protected double m_lowerLimit;

		protected double m_upperLimit;

		//账户
		public ClubAccount Account { get; set; }

		//金额
		public double Balance { get; set; }

		public void Deposit(double amount)
		{
			Balance += amount;
			Console.WriteLine("这次存入了{0}元，你的帐户还有{1}元", amount, Balance);
			StateChangeCheck();
		}

		public void Cost(double amount)
		{
			Balance -= amount;
			Console.WriteLine("这次消费了{0}元，你的帐户还有{1}元", amount, Balance);
			StateChangeCheck();
		}

		protected abstract void StateChangeCheck();

		public abstract void ClubService();
	}
}