#region

using System;
using System.Windows.Forms;

#endregion

namespace 动物运动会_泛型 {
    internal static class Program {
        /// <summary>
        ///     应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form11());
        }
    }
}