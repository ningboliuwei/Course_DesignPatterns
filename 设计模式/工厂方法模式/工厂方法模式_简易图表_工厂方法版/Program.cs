﻿#region

using System;
using System.Windows.Forms;

#endregion

namespace 工厂方法模式_简易图表_工厂方法版 {
    internal static class Program {
        /// <summary>
        ///     应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}