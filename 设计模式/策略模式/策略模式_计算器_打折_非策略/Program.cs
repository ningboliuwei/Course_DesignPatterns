using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 策略模式_计算器_打折_非策略
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
			Application.Run(new Caculator());
		}
	}
}