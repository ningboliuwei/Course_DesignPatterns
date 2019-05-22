using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式_共享状态_开关
{
    class Switch
    {
        private readonly Dictionary<string, SwitchState> _states = new Dictionary<string, SwitchState> {
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