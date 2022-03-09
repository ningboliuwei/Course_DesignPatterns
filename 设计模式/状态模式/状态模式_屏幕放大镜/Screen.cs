namespace 状态模式_屏幕放大镜 {
    internal class Screen {
        private State _currentState;
        private readonly State _largerState;
        private readonly State _largestState;
        private readonly State _normalState;

        public Screen() {
            _normalState = new NormalState();
            _largerState = new LargerState();
            _largestState = new LargestState();

            SetState(_normalState);
            _currentState.Display();
        }

        public void OnClick() {
            if (_currentState == _normalState) {
                SetState(_largerState);
            }
            else if (_currentState == _largerState) {
                SetState(_largestState);
            }
            else if (_currentState == _largestState) {
                SetState(_normalState);
            }

            _currentState.Display(); //刘伟版将此行在三个分支中都重复了
        }

        public void SetState(State state) {
            _currentState = state;
        }
    }
}