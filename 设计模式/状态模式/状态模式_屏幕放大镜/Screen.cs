using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式_屏幕放大镜
{
    class Screen
    {
        private State m_currentState;
        private State m_normalState;
        private State m_largerState;
        private State m_largestState;

        public Screen()
        {
            m_normalState = new NormalState();
            m_largerState = new LargerState();
            m_largestState = new LargestState();
           
            SetState(m_normalState);
            m_currentState.Display();

        }

        public void SetState(State state)
        {
            m_currentState = state;
        }

        public void OnClick()
        {
            if (m_currentState == m_normalState)
            {
                SetState(m_largerState);
            }
            else if (m_currentState == m_largerState)
            {
                SetState(m_largestState);
            }
            else if (m_currentState == m_largestState)
            {
                SetState(m_normalState);
            }
            else
            {
                
            }

            m_currentState.Display();//刘伟版将此行在三个分支中都重复了
        }
    }
}
