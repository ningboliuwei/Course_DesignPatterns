namespace 命令模式_遥控汽车 {
    public abstract class CarCombineCommand {
        public abstract void MoveBackwards();

        public abstract void MoveForwards();
        public abstract void Start();

        public abstract void Stop();
    }
}