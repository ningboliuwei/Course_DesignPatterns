using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式_数据库_非工厂版
{
	class SqlserverUser
	{
		public void Insert(User user)
		{
			//Console.WriteLine("在SQL SERVER中给User表增加一条记录");
			//创建SqlConnection对象
			//拼接SQL命令 INSERT INTO USER VALUES('{0}','{1}') , user.ID, user.Name
			//创建SqlCommand对象
			//调用SqlCommand对象的.ExecuteNonQuery()
		}

		public User GetUser(int id)
		{
			Console.WriteLine("在SQL SERVER中根据id {0}得到User表一条记录", id);
			return;
		}
	}
}