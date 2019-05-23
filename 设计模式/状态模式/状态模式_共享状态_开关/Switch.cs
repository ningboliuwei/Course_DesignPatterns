using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式_共享状态_开关
{
    class Switch
    {
        // 试着加上或者不加 static，然后用 Console.WriteLine(s.CurrentState.GetHashCode()); 查看是否是同一个对象
        private static readonly Dictionary<string, SwitchState> _states = new Dictionary<string, SwitchState> {
            {"ON", new OnState()},
            {"OFF", new OffState()}
        };

        public string Name { get; set; }

        public SwitchState CurrentState { get; set; }

        public Switch() {
            CurrentState = GetState("OFF");
        }

        public SwitchState GetState(string key) {
            return _states[key];
        }

        public void Press() {
            CurrentState.Press(this);
        }
    }
}