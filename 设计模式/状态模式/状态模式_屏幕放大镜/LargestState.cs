#region

using System;

#endregion

namespace 状态模式_屏幕放大镜 {
    internal class LargestState : State {
        public override void Display() {
            Console.WriteLine("四倍大小");
        }
    }
}