using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 装饰模式_用户登录_传统版
{
	internal class User
	{
		public string Name { get; set; }
		public string Password { get; set; }

		public virtual void SignIn()
		{
			Console.WriteLine("用户登入");
		}
	}
}