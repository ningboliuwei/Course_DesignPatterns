#region

using System;

#endregion

namespace 适配器模式_对象适配器 {
    internal class Program {
        private static void Main(string[] args) {
            Target target = new Adapter();
            target.Request();

            Console.ReadLine();
        }
    }
}