using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 装饰模式_用户登录_传统版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			User user1 = new User();
			user1.Name = "admin";
			user1.Password = "123456";
			user1.SignIn();

			User user2 = new User();
			user2.Name = "admin";
			user2.Password = "12345";
			user2.SignIn();

			try
			{
				RegisteredUser registeredUser1 = new RegisteredUser();
				registeredUser1.Name = "admin";
				registeredUser1.Password = "123456";
				registeredUser1.SignIn();

				RegisteredUser registeredUser2 = new RegisteredUser();
				registeredUser2.Name = "admin";
				registeredUser2.Password = "12345";
				registeredUser2.SignIn();
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception.Message);
			}

			Console.ReadLine();
		}
	}
}