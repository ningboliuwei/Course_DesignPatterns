#region

using System;

#endregion

namespace 外观模式_家庭影院_外观模式版 {
    internal class Projector {
        public void Off() {
            Console.WriteLine("投影仪已关闭");
        }

        public void On() {
            Console.WriteLine("投影仪已打开");
        }

        public void SetDvd() {
            Console.WriteLine("投影仪输入已设为 DVD");
        }

        public void SetWideScreenMode() {
            Console.WriteLine("投影仪已设为宽屏模式");
        }
    }
}