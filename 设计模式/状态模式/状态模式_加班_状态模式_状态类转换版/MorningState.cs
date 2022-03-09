#region

using System;

#endregion

namespace 状态模式_加班_状态模式_状态类转换版 {
    internal class MorningState : State {
        public override void Coding(Work work) {
            if (work.Hour < 12) {
                Console.WriteLine($"当前时间：{work.Hour}点 上午工作，精神百倍");
            }
            else {
                work.SetState(new NoonState());
                work.Coding();
            }
        }
    }
}