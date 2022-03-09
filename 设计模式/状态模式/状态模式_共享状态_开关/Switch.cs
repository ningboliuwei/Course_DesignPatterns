#region

using System.Collections.Generic;

#endregion

namespace 状态模式_共享状态_开关_多私有成员版 {
    public class Switch {
        // 试着加上或者不加 static，然后用 Console.WriteLine(s.CurrentState.GetHashCode()); 查看是否是同一个对象
        // 如果是用 _onState 和 _offState 两个私有成员呢？
        private static readonly Dictionary<string, SwitchState> _states = new Dictionary<string, SwitchState> {
            { "ON", new OnState() },
            { "OFF", new OffState() }
        };

        public Switch() {
            CurrentState = GetState("OFF");
        }

        public SwitchState CurrentState { get; set; }

        public string Name { get; set; }

        public SwitchState GetState(string key) {
            return _states[key];
        }

        public void Press() {
            CurrentState.Press(this);
        }
    }
}