namespace 命令模式_遥控汽车 {
    public abstract class CarSeperateCommand {
        private Car _car;

        public CarSeperateCommand(Car mycar) {
            _car = mycar;
        }

        public abstract void Excute();
    }
}