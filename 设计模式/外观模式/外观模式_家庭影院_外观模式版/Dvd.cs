#region

using System;

#endregion

namespace 外观模式_家庭影院_外观模式版 {
    internal class Dvd {
        public void Off() {
            Console.WriteLine("DVD 已关闭");
        }

        public void On() {
            Console.WriteLine("DVD 已打开");
        }

        public void Play() {
            Console.WriteLine("DVD 开始播放");
        }

        public void Stop() {
            Console.WriteLine("DVD 停止播放");
        }
    }
}