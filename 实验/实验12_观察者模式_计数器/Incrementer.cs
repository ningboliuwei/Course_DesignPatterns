#region

using System.Threading;

#endregion

namespace 实验12_观察者模式_计数器 {
    internal class Incrementer {
        public int CountNumber;
        public int StartNumber;

        public void Count() {
            CountStart?.Invoke(this, new CountStartEventArgs { StartNumber = StartNumber });

            for (var i = StartNumber; i <= StartNumber + CountNumber; i++) {
                Counting?.Invoke(this, new CountingEventArgs { CurrentNumber = i });
                Thread.Sleep(1000);
            }

            CountEnd?.Invoke(this, new CountEndEventArgs { EndNumber = StartNumber + CountNumber });
        }

        public event CountEndHandler CountEnd;
        public event CountingHandler Counting;

        public event CountStartHandler CountStart;
    }
}