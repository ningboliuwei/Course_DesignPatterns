using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 实验12_观察者模式_计数器 {
    class Incrementer {
        public int StartNumber;
        public int CountNumber;

        public event CountStartHandler CountStart;
        public event CountingHandler Counting;
        public event CountEndHandler CountEnd;

        public void Count() {
            CountStart?.Invoke(this, new CountStartEventArgs {StartNumber = StartNumber});

            for (int i = StartNumber; i <= StartNumber + CountNumber; i++) {
                Counting?.Invoke(this, new CountingEventArgs {CurrentNumber = i});
                Thread.Sleep(1000);
            }

            CountEnd?.Invoke(this, new CountEndEventArgs {EndNumber = StartNumber + CountNumber});
        }

     
    }
}