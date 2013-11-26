using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_俱乐部
{
	internal class ClubAccount
	{
		//顾客姓名
		public string CustomerName { get; set; }

		public ClubState State { get; set; }

		public double Balance
		{
			get
			{
				return State.Balance;
			}
		}

		public ClubAccount(string name) //构造函数
		{
			CustomerName = name;
			State = new VisitorState(0.0, this);
		}

		public void Deposit(double amount)
		{
			State.Deposit(amount);
		}

		public void Cost(double amount)
		{
			State.Cost(amount);
		}

		public void ClubService()
		{
			State.ClubService();
		}
	}
}