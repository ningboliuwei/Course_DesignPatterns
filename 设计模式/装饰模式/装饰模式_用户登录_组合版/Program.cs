using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 装饰模式_用户登录_组合版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			User user1 = new User();
			user1.Name = "admin";
			user1.Password = "123456";
			user1.SignIn();

			try
			{
				RegisteredUser registeredUser1 = new RegisteredUser();
				registeredUser1.User = user1;
				registeredUser1.User.Name = "admin";
				registeredUser1.User.Password = "123456";

				registeredUser1.SignIn();
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception.Message);
			}

			// User user = new RegisteredUser();

			Console.ReadLine();
		}
	}
}