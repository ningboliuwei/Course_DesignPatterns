namespace 实验16_命令模式_自定义按键 {
    public class HelperCommand : ICommand {
        private readonly HelpHandler _helpHandler;

        public HelperCommand() {
            _helpHandler = new HelpHandler();
        }

        public void Execute() {
            _helpHandler.Display();
        }
    }
}