using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验12_观察者模式_计数器 {
    class ConsoleOutputer {
        public void ShowCountStart(object sender, CountStartEventArgs e) {
            Console.WriteLine($"计数从 {e.StartNumber} 开始");
        }

        public void ShowCounting(object sender, CountingEventArgs e) {
            Console.WriteLine($"当前计数到 {e.CurrentNumber}");
        }

        public void ShowCountEnd(object sender, CountEndEventArgs e) {
            Console.WriteLine($"计数到 {e.EndNumber} 结束");
        }
    }
}