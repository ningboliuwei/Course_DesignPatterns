namespace 命令模式_烤肉串_松耦合 {
    internal abstract class Command {
        protected Chef _chef;

        public Command(Chef chef) {
            _chef = chef;
        }

        public abstract void ExecuteCommand();
    }
}