using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_俱乐部
{
	internal class MemberState : ClubState
	{
		public MemberState(ClubState state)
			: this(state.Balance, state.Account) //调用本类的构造函数
		{
			Balance = state.Balance;
			Initialize();
		}

		public MemberState(double balance, ClubAccount account)
		{
			Balance = balance;
			Account = account;
			Initialize();
		}

		private void Initialize()
		{
			this.m_lowerLimit = 100;
			this.m_upperLimit = 1000;
		}

		protected override void StateChangeCheck()
		{
			if (Balance < this.m_lowerLimit)
			{
				Account.State = new VisitorState(this);
				Console.WriteLine("你当前帐户金额为 {0}，你降级为‘访客级会员’服务", Balance);
			}
			else if (Balance >= this.m_upperLimit)
			{
				Account.State = new VIPState(this);
				Console.WriteLine("你当前帐户金额为 {0}，你升级为‘贵宾级会员’服务", Balance);
			}
		}

		public override void ClubService()
		{
			Console.WriteLine("你申请了服务==>俱乐部提供‘普通级会员’的服务内容！");
			Console.WriteLine();
		}
	}
}