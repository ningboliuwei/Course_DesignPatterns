using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式_数据库_抽象工厂_反射版
{
	internal class AccessUser : IUser
	{
		public void Insert(User user)
		{
			Console.WriteLine("在Access中给User表增加一条记录");
		}

		public User GetUser(int id)
		{
			Console.WriteLine("在Access中根据ID得到User表一条记录");
			return null;
		}
	}
}