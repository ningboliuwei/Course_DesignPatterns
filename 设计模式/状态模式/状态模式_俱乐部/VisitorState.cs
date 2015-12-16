using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_俱乐部
{
	internal class VisitorState : ClubState
	{
		public VisitorState(ClubState state)
			: this(state.Balance, state.Account) //调用本类的构造函数
		{
		}

		public VisitorState(double balance, ClubAccount account)
		{
			Balance = balance;
			Account = account;
			Initialize();
		}

		private void Initialize()
		{
			this._lowerLimit = 0.0;
			this._upperLimit = 100;
		}

		protected override void StateChangeCheck()
		{
			if (Balance >= this._upperLimit)
			{
				Account.State = new MemberState(this);
				Console.WriteLine("你当前帐户金额为{0}，你升级为‘普通级会员’服务", Balance);
			}
		}

		public override void ClubService()
		{
			Console.WriteLine("你申请了服务==>俱乐部提供‘访客级会员’的服务内容！");
			Console.WriteLine();
		}
	}
}