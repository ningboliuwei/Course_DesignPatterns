using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式_自定义功能键_命令队列版
{
	class Program
	{
		static void Main(string[] args)
		{
			FunctionButton fb1 = new FunctionButton("功能键1");
			FunctionButton fb2 = new FunctionButton("功能键2");
			FunctionButton fb3 = new FunctionButton("功能键3");

			List<FunctionButton> functionButtons = new List<FunctionButton>();
			functionButtons.Add(fb1);
			functionButtons.Add(fb2);
			functionButtons.Add(fb3);

			foreach (FunctionButton fb in functionButtons)
			{
				string function = "-1";

				while (function != "0")
				{
					Console.WriteLine("为{0}设置功能：1.显示帮助 2.最小化 3.截屏。按0结束。", fb.Name);
					function = Console.ReadLine();
					switch (function)
					{
						case "1":
							fb.AddCommand(new HelperCommand());
							break;
						case "2":
							fb.AddCommand(new MinimizeCommand());
							break;
						case "3":
							fb.AddCommand(new ScreenShotCommand());
							break;

					}
				}
			}

			//第四步结束

			Console.WriteLine(fb1.Name);
			fb1.Click();
			Console.WriteLine("----------");

			Console.WriteLine(fb2.Name);
			fb2.Click();
			Console.WriteLine("----------");

			Console.WriteLine(fb3.Name);
			fb3.Click();
			Console.WriteLine("----------");

			Console.ReadLine();

		}
	}
}
