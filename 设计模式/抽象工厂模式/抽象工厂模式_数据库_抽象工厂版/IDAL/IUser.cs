using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式_数据库_抽象工厂_非反射版
{
	internal interface IUser
	{
		void Insert(User user);

		User GetUser(int id);
	}
}