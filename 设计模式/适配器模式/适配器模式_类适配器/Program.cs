#region

using System;

#endregion

namespace 适配器模式_类适配器 {
    internal class Program {
        private static void Main(string[] args) {
            ITarget target = new Adapter();
            target.Request();

            Console.ReadLine();
        }
    }
}