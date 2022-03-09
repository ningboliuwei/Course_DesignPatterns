namespace 命令模式_自定义功能键_命令队列版 {
    internal class ScreenShotCommand : Command {
        private readonly ScreenShotHandler screenShotHandler;

        public ScreenShotCommand() {
            screenShotHandler = new ScreenShotHandler();
        }

        public override void Execute() {
            screenShotHandler.Shot();
        }
    }
}