using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 工厂方法模式_加密算法选择_应用实例
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