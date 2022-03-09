#region

using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using 动物运动会;

#endregion

namespace 动物运动会_有名字 {
    internal static class Program {
        /// <summary>
        ///     应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form4());

            // IEnumerable
            var array = new int[3];
            var list = new List<int>();
            var e1 = array.GetEnumerator();
            var e2 = list.GetEnumerator();

            var enumerableObjects = new IEnumerable[2];
            enumerableObjects[0] = array;
            enumerableObjects[1] = list;

            foreach (var t in enumerableObjects) {
                t.GetEnumerator();
            }
        }
    }
}