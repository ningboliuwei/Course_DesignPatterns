#region

using System;

#endregion

namespace 实验12_观察者模式_计数器 {
    internal class ConsoleOutputer {
        public void ShowCountEnd(object sender, CountEndEventArgs e) {
            Console.WriteLine($"计数到 {e.EndNumber} 结束");
        }

        public void ShowCounting(object sender, CountingEventArgs e) {
            Console.WriteLine($"当前计数到 {e.CurrentNumber}");
        }

        public void ShowCountStart(object sender, CountStartEventArgs e) {
            Console.WriteLine($"计数从 {e.StartNumber} 开始");
        }
    }
}