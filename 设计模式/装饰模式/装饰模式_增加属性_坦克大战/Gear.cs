namespace 装饰模式_增加属性_坦克大战 {
    internal class Gear : Tank {
        private readonly Tank _tank;

        public Gear(Tank tank) {
            _tank = tank;
        }

        public override void BeAttacked() {
            _tank.BeAttacked();
        }

        public override void Move() {
            _tank.Move();
        }
    }
}