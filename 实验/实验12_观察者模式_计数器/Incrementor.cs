using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 实验12_观察者模式_计数器 {
    class Incrementor {
        public int StartNumber;
        public int CountNumber;

        public delegate void CountStartHandler(object sender, CountStartEventArgs e);

        public delegate void CountingHandler(object sender, CountingEventArgs e);

        public delegate void CountEndHandler(object sender, CountEndEventArgs e);

        public event CountStartHandler CountStart;
        public event CountingHandler Counting;
        public event CountEndHandler CountEnd;

        public void Count() {
            if (CountStart != null) {
                CountStart(this, new CountStartEventArgs {StartNumber = StartNumber});
            }

            for (int i = StartNumber; i < StartNumber + CountNumber; i++) {
                if (Counting != null) {
                    Counting(this, new CountingEventArgs {CurrentNumber = i});
                }
                Thread.Sleep(1000);
            }

            if (CountEnd != null) {
                CountEnd(this, new CountEndEventArgs {EndNumber = StartNumber + CountNumber});
            }
        }

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