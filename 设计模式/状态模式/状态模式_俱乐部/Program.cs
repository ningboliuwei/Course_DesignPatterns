using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_俱乐部
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("-------------俱乐部会员服务的状态模式实现--------------");
			ClubAccount account = new ClubAccount("张三");
			account.ClubService();

			account.Deposit(100);
			account.ClubService();

			account.Deposit(300);
			account.ClubService();

			account.Deposit(1000);
			account.ClubService();

			account.Cost(100);
			account.ClubService();

			account.Cost(1000);
			account.ClubService();

			account.Cost(300);
			account.ClubService();

			Console.ReadLine();
		}
	}
}