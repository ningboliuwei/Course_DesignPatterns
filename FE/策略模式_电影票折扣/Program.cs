using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式_电影票折扣
{
	class Program
	{
		static void Main(string[] args)
		{
			string type = "";
			MovieTicket movieTicket = new MovieTicket();

			Console.WriteLine("请选择顾客类别：");
			Console.WriteLine("1. 学生  2. 儿童  3. VIP");
			type = Console.ReadLine();

			switch (type)
			{
				case "1":
					movieTicket.SetDiscount(new StudentDiscount());
					break;
				case "2":
					movieTicket.SetDiscount(new ChildrenDiscount());
					break;
				case "3":
					movieTicket.SetDiscount(new VIPDiscount());
					break;
			}

			movieTicket.GetPrice();
			Console.ReadLine();
		}
	}
}
