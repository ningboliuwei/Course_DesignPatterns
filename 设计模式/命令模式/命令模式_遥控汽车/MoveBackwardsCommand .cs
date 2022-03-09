#region

using System.Collections;

#endregion

namespace 命令模式_遥控汽车 {
    internal class MoveBackwardsCommand : CarSeperateCommand {
        private readonly Car _car;

        private readonly ArrayList CarState;

        public MoveBackwardsCommand(Car car, ArrayList state)
            : base(car) {
            _car = car;
            CarState = state;
        }

        public override void Excute() {
            _car.MoveBackwards();
            _car._curStateStr += "-MoveBackwards";
            CarState.Add(_car._curStateStr);
        }
    }
}