namespace 命令模式_遥控汽车 {
    internal class CarSeperateInvoker {
        private readonly CarSeperateCommand _movebackwards;

        private readonly CarSeperateCommand _moveforwards;
        private readonly CarSeperateCommand _start;

        private readonly CarSeperateCommand _stop;

        private readonly CarSeperateCommand _undo;

        public CarSeperateInvoker(
            CarSeperateCommand start,
            CarSeperateCommand moveforwards,
            CarSeperateCommand movebackwards,
            CarSeperateCommand stop,
            CarSeperateCommand undo) {
            _start = start;
            _moveforwards = moveforwards;
            _movebackwards = movebackwards;
            _stop = stop;
            _undo = undo;
        }

        public void MoveBackwards() {
            _movebackwards.Excute();
        }

        public void MoveForwards() {
            _moveforwards.Excute();
        }

        public void Start() {
            _start.Excute();
        }

        public void Stop() {
            _stop.Excute();
        }

        public void Undo() {
            _undo.Excute();
        }
    }
}