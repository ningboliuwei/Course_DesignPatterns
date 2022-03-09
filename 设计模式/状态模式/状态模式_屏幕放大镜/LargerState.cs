#region

using System;

#endregion

namespace 状态模式_屏幕放大镜 {
    internal class LargerState : State {
        public override void Display() {
            Console.WriteLine("两倍大小");
        }
    }
}