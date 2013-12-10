using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式_自定义功能键_传统版
{
	class Program
	{
		static void Main(string[] args)
		{
			FunctionButton functionButton = new FunctionButton();
			functionButton.Click();

			Console.ReadLine();
		}
	}
}
