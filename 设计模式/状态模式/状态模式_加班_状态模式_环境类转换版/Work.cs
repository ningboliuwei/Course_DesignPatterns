namespace 状态模式_加班_状态模式_环境类转换版
{
    public class Work
    {
        private State _currentState;

        public Work()
        {
            SetState(new MorningState());
        }

        //当前钟点      
        public double Hour { get; set; }

        //是否完成了工作
        public bool TaskFinished { get; set; }

        public void SetState(State state)
        {
            _currentState = state;
        }

        public void ChangeState()
        {
            if (Hour < 12)
            {
                _currentState = new MorningState();
            }
            else if (Hour < 13)
            {
                _currentState = new NoonState();
            }
            else if (Hour < 17)
            {
                _currentState = new AfternoonState();
            }
            else
            {
                if (TaskFinished)
                {
                    _currentState = new RestState();
                }
                else
                {
                    if (Hour < 21)
                    {
                        _currentState = new EveningState();
                    }
                    else
                    {
                        _currentState = new SleepingState();
                    }
                }
            }
        }

        public void Coding()
        {
            ChangeState();
            _currentState.Coding(this);
        }
    }
}