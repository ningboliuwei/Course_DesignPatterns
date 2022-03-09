#region

using System;

#endregion

namespace 适配器模式_日志_类适配器 {
    internal class Program {
        private static void Main(string[] args) {
            ILogTarget dbLog = new DatabaseLogAdapter();
            dbLog.Write();

            ILogTarget fileLog = new FileLogAdapter();
            fileLog.Write();

            Console.ReadLine();
        }
    }
}