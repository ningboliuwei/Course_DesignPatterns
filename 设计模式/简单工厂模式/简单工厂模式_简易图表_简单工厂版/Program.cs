﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 简单工厂模式_简易图表_简单工厂版
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