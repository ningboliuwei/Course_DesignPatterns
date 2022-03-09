﻿namespace 命令模式_烤肉串_松耦合 {
    internal class BakeChickenWingCommand : Command {
        public BakeChickenWingCommand(Chef chef)
            : base(chef) {
        }

        public override void ExecuteCommand() {
            _chef.BakeChickenWing();
        }
    }
}