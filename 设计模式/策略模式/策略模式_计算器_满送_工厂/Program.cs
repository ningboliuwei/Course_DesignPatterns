﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using 策略模式_计算器_满送_工厂;

namespace 策略模式_计算器_满送_工厂_计算器_满送_工厂
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