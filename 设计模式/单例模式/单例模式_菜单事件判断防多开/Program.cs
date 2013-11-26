using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 单例模式_菜单事件判断防多开
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