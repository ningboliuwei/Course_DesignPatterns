#region

using System;

#endregion

namespace 外观模式_家庭影院_传统版 {
    internal class Popper {
        public void Off() {
            Console.WriteLine("爆米花机已关闭");
        }

        public void On() {
            Console.WriteLine("爆米花机已打开");
        }

        public void Pop() {
            Console.WriteLine("爆米花机开始爆米花");
        }
    }
}