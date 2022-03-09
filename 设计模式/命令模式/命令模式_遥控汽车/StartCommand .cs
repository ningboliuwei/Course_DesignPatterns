#region

using System.Collections;

#endregion

namespace 命令模式_遥控汽车 {
    internal class StartCommand : CarSeperateCommand {
        private readonly Car _car;

        private readonly ArrayList CarState;

        public StartCommand(Car car, ArrayList state)
            : base(car) {
            _car = car;
            CarState = state;
        }

        public override void Excute() {
            _car.Start();
            _car._curStateStr += "-Start";
            CarState.Add(_car._curStateStr);
        }
    }
}