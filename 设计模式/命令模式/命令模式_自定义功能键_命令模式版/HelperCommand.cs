namespace 命令模式_自定义功能键_命令模式版 {
    internal class HelperCommand : Command {
        private readonly HelpHandler helpHandler;

        public HelperCommand() {
            helpHandler = new HelpHandler();
        }

        public override void Execute() {
            helpHandler.Display();
        }
    }
}