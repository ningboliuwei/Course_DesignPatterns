namespace 命令模式_自定义功能键_命令队列版 {
    internal class MinimizeCommand : Command {
        private readonly MinimizeHandler minimizeHandler;

        public MinimizeCommand() {
            minimizeHandler = new MinimizeHandler();
        }

        public override void Execute() {
            minimizeHandler.Minimize();
        }
    }
}