namespace 命令模式_烤肉串_命令模式_合成 {
    internal abstract class CommandCombine {
        protected Chef _chef;

        public CommandCombine(Chef chef) {
            _chef = chef;
        }

        public abstract void BackChickenWingCommand();

        public abstract void BakeLampCommand();
    }
}