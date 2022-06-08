namespace 实验16_命令模式_自定义按键 {
    public class ScreenShotCommand : ICommand {
        private readonly ScreenShotHandler screenShotHandler;

        public ScreenShotCommand() {
            screenShotHandler = new ScreenShotHandler();
        }

        public void Execute() {
            screenShotHandler.Shot();
        }
    }
}