namespace 状态模式_共享状态_开关_多私有成员版 {
    public class Switch {
        private static readonly OnState _onState = new OnState();
        private static readonly OffState _offState = new OffState();

        public Switch() {
            CurrentState = _offState;
        }

        public SwitchState CurrentState { get; set; }

        public string Name { get; set; }

        public SwitchState GetState(string key) {
            if (key == "ON") {
                return _onState;
            }

            if (key == "OFF") {
                return _offState;
            }

            return null;
        }

        public void Press() {
            CurrentState.Press(this);
        }
    }
}