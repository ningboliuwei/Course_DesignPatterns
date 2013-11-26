using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式_数据库_非工厂版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			User user1 = new User();
			user1.ID = 1;
			user1.Name = "Tom";

			User user2 = new User();
			user2.ID = 2;
			user2.Name = "Jane";

			SqlserverUser su = new SqlserverUser();
			su.Insert(user1);
			su.Insert(user2);

			User resultUser1 = su.GetUser(1);
			User resultUser2 = su.GetUser(2);

			Console.ReadLine();
		}
	}
}