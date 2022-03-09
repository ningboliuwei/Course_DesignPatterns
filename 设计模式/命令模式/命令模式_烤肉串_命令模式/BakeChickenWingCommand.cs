namespace 命令模式_烤肉串_命令模式 {
    internal class BakeChickenWingCommand : Command {
        public BakeChickenWingCommand(Chef receiver)
            : base(receiver) {
        }

        public override void ExecuteCommand() {
            _receiver.BakeChickenWing();
        }
    }
}