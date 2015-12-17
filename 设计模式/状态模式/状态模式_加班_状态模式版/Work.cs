namespace 状态模式_加班_状态模式_状态类转换版
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

        public void Coding()
        {
            _currentState.Coding(this);
        }
    }
}