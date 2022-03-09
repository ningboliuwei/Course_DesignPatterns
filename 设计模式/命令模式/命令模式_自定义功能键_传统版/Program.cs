#region

using System;

#endregion

namespace 命令模式_自定义功能键_传统版 {
    internal class Program {
        private static void Main(string[] args) {
            var functionButton = new FunctionButton();
            functionButton.Click();

            Console.ReadLine();
        }
    }
}