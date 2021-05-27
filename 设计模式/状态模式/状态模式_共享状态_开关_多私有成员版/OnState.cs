using System;

namespace 状态模式_共享状态_开关
{
    public class OnState : SwitchState
    {
        public override void Press(Switch s) {
            s.CurrentState = s.GetState("OFF");
            Console.WriteLine($"开关 {s.Name} 被关闭了");
            Console.WriteLine(s.CurrentState.GetHashCode());
        }
    }
}