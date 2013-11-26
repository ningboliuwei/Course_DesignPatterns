using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_俱乐部
{
	internal class VIPState : ClubState
	{
		public VIPState(ClubState state)
			: this(state.Balance, state.Account)
		{
			Balance = state.Balance;
		}

		public VIPState(double balance, ClubAccount account)
		{
			Balance = balance;
			Account = account;
			Initialize();
		}

		private void Initialize()
		{
			_lowerLimit = 1000.0;
		}

		protected override void StateChangeCheck()
		{
			if (Balance < _lowerLimit)
			{
				Account.State = new MemberState(this);
				Console.WriteLine("你当前帐户金额为 {0}，你降级为‘普通级会员’服务!", Balance.ToString());
			}
		}

		public override void ClubService()
		{
			Console.WriteLine("你申请了服务==>俱乐部提供‘贵宾级会员’的服务内容！");
			Console.WriteLine();
		}
	}
}