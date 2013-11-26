using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace 抽象工厂模式_数据库_抽象工厂_非反射版
{
	using System.Data.SqlClient;

	internal class Program
	{
		private static void Main(string[] args)
		{
			User user = new User();
			Department dept = new Department();

			//IFactory factory = new SqlserverFactory();//创建在SQL Server环境下使用的数据对象
			IFactory factory = new AccessFactory(); //创建在Access环境下使用的数据对象

			IUser iu = factory.CreateUser();
			iu.Insert(user);
			iu.GetUser(1);

			IDepartment idept = factory.CreateDepartment();
			idept.Insert(dept);
			idept.GetDepartment(1);

			Console.ReadLine();
		}
	}
}