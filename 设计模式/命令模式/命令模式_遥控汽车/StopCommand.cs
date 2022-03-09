#region

using System.Collections;

#endregion

namespace 命令模式_遥控汽车 {
    internal class StopCommand : CarSeperateCommand {
        private readonly Car _car;

        private readonly ArrayList CarState;

        public StopCommand(Car car, ArrayList state)
            : base(car) {
            _car = car;
            CarState = state;
        }

        public override void Excute() {
            _car.Stop();
            _car._curStateStr += "-Stop";
            CarState.Add(_car._curStateStr);
        }
    }
}