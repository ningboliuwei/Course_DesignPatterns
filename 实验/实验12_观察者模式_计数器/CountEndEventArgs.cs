#region

using System;

#endregion

namespace 实验12_观察者模式_计数器 {
    internal class CountEndEventArgs : EventArgs {
        public int EndNumber;
    }
}