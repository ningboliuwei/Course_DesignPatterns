using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式_共享状态_开关
{
    class Switch
    {
        private static SwitchState _currentState;
        private static SwitchState _onState = new OnState();
        private static SwitchState _offState = new OffState();

        public string Name { get; set; }

        public Switch() {
            _currentState = _offState;
        }

        public void SetState(SwitchState state) {
            _currentState = state;
        }

        public SwitchState GetCurrentState() {
            return _currentState;
        }

        public SwitchState GetOnState() {
            return _onState;
        }

        public SwitchState GetOffState() {
            return _offState;
        }

        public void Press() {
            _currentState.Press(this);
        }
    }
}