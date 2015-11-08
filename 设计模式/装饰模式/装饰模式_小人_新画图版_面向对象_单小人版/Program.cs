using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 装饰模式_小人_新画图版_面向对象_单小人版
{
	internal static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}