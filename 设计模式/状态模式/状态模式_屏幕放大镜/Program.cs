#region

using System;

#endregion

namespace 状态模式_屏幕放大镜 {
    internal class Program {
        private static void Main(string[] args) {
            var screen = new Screen();

            screen.OnClick();
            screen.OnClick();
            screen.OnClick();

            Console.ReadLine();
        }
    }
}