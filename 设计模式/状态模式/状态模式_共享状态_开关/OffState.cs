#region

using System;

#endregion

namespace 状态模式_共享状态_开关_多私有成员版 {
    public class OffState : SwitchState {
        public override void Press(Switch s) {
            s.CurrentState = s.GetState("ON");
            Console.WriteLine($"开关 {s.Name} 被打开了");
            Console.WriteLine(s.CurrentState.GetHashCode());
        }
    }
}