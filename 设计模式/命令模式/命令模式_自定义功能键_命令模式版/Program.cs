using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式_自定义功能键_命令模式版
{
	class Program
	{
		static void Main(string[] args)
		{
			FunctionButton fb1 = new FunctionButton("功能键1");
			FunctionButton fb2 = new FunctionButton("功能键2");
			FunctionButton fb3 = new FunctionButton("功能键3");

			//第一步开始
			fb1.SetCommand(new HelperCommand());
			fb2.SetCommand(new MinimizeCommand());
			fb3.SetCommand(new ScreenShotCommand());
			//第一步结束

			//第二步开始
			fb1.SetCommand(new MinimizeCommand());
			fb2.SetCommand(new HelperCommand());
			fb3.SetCommand(new ScreenShotCommand());
			//第二步结束

			//第三步开始
			fb1.SetCommand(new ScreenShotCommand());
			fb2.SetCommand(new HelperCommand());
			fb3.SetCommand(new MinimizeCommand());
			//第三步结束

			//第四步开始
			List<FunctionButton> functionButtons = new List<FunctionButton>();
			functionButtons.Add(fb1);
			functionButtons.Add(fb2);
			functionButtons.Add(fb3);

			foreach (FunctionButton fb in functionButtons)
			{
				Console.WriteLine("为{0}设置功能：1.显示帮助 2.最小化 3.截屏", fb.Name);
				string function = Console.ReadLine();
				switch (function)
				{
					case "1":
						fb.SetCommand(new HelperCommand());
						break;
					case "2":
						fb.SetCommand(new MinimizeCommand());
						break;
					case "3":
						fb.SetCommand(new ScreenShotCommand());
						break;

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
