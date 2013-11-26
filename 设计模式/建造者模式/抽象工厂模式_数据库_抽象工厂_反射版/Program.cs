using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式_数据库_抽象工厂_反射版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			User user = new User();
			Department dept = new Department();

			IUser iu = DataAccess.CreateUser();
			iu.Insert(user);
			iu.GetUser(1);

			IDepartment idept = DataAccess.CreateDepartment();
			idept.Insert(dept);
			idept.GetDepartment(1);

			Console.ReadLine();
		}
	}
}