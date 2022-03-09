namespace 状态模式_手枪 {
    internal abstract class State {
        protected Pistol m_pistol;

        public abstract void Fire();

        public abstract void Reload();
    }
}