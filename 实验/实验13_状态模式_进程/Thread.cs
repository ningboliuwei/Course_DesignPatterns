namespace 实验13_状态模式_进程 {
    internal class Thread {
        public State CurrentState { get; set; } = new New();
        public int ThreadId { get; set; }

        public void GetCPU() {
            ((Ready)CurrentState).GetCPU(this);
        }

        public void Resume() {
            ((Blocked)CurrentState).Resume(this);
        }

        public void Start() {
            ((New)CurrentState).Start(this);
        }

        public void Stop() {
            ((Running)CurrentState).Stop(this);
        }

        public void Suspend() {
            ((Running)CurrentState).Suspend(this);
        }
    }
}