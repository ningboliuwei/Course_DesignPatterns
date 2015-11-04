using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace 抽象工厂模式_数据库_抽象工厂_非反射版
{
	using System.Data.SqlClient;

	class Program
	{
		private static void Main(string[] args)
		{
			User user = new User();
			Department dept = new Department();

			//创建在SQL Server环境下使用的数据对象
			IFactory factory = new SqlserverFactory();
			//创建在MySQL环境下使用的数据对象
			//IFactory factory = new MysqlFactory();

			IUser u = factory.CreateUser();
			u.Insert(user);
			u.GetUser(1);

			// IDepartment idept = factory.CreateDepartment();
			// idept.Insert(dept);
			// idept.GetDepartment(1);

			Console.ReadLine();
		}
	}
}