#region

using System;

#endregion

namespace 状态模式_加班_状态模式_环境类转换版 {
    internal class SleepingState : State {
        public override void Coding(Work work) {
            Console.WriteLine($"当前时间：{work.Hour}点 不行了，睡着了");
        }
    }
}