using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_加班_状态模式_环境类转换版
{
    public class Work
    {
        private State m_currentState;

        public Work()
        {
            this.SetState(new MorningState());
        }

        //当前钟点      
        public double Hour { get; set; }

        //是否完成了工作
        public bool TaskFinished { get; set; }

        public void SetState(State state)
        {
            this.m_currentState = state;
        }

        public void ChangeState()
        {
            if (Hour < 12)
            {
                m_currentState = new MorningState();
            }
            else if (Hour < 13)
            {
                m_currentState = new NoonState();
            }
            else if (Hour < 17)
            {
                m_currentState = new AfternoonState();
            }
            else
            {
                if (TaskFinished)
                {
                    m_currentState = new RestState();
                }
                else
                {
                    if (Hour < 21)
                    {
                        m_currentState = new EveningState();
                    }
                    else
                    {
                        m_currentState = new SleepingState();
                    }
                }
            }
        }

        public void WriteProgram()
        {
            ChangeState();
            m_currentState.WriteProgram(this);
        }
    }
}