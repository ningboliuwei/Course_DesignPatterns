#region

using System;

#endregion

namespace 状态模式_屏幕放大镜 {
    internal class NormalState : State {
        public override void Display() {
            Console.WriteLine("普通大小");
        }
    }
}