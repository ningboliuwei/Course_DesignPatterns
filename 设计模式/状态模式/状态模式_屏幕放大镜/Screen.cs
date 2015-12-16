using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式_屏幕放大镜
{
    class Screen
    {
        private State _currentState;
        private State _normalState;
        private State _largerState;
        private State _largestState;

        public Screen()
        {
            _normalState = new NormalState();
            _largerState = new LargerState();
            _largestState = new LargestState();
           
            SetState(_normalState);
            _currentState.Display();

        }

        public void SetState(State state)
        {
            _currentState = state;
        }

        public void OnClick()
        {
            if (_currentState == _normalState)
            {
                SetState(_largerState);
            }
            else if (_currentState == _largerState)
            {
                SetState(_largestState);
            }
            else if (_currentState == _largestState)
            {
                SetState(_normalState);
            }
            else
            {
                
            }

            _currentState.Display();//刘伟版将此行在三个分支中都重复了
        }
    }
}
