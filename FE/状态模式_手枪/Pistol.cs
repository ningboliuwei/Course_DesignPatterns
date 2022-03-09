namespace 状态模式_手枪 {
    internal class Pistol {
        private State m_currentState;

        public Pistol() {
            BulletCount = 3;
            m_currentState = new LoadedState(this);
        }

        public int BulletCount { get; set; }

        public void Fire() {
            m_currentState.Fire();
        }

        public void Reload() {
            m_currentState.Reload();
        }

        public void SetState(State state) {
            m_currentState = state;
        }
    }
}