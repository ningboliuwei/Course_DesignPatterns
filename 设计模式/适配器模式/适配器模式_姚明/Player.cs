namespace 适配器模式_姚明 {
    internal abstract class Player {
        protected string _name;

        public Player(string name) {
            _name = name;
        }

        public abstract void Attack();

        public abstract void Defense();
    }
}