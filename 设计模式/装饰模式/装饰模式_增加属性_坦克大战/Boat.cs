#region

using System;

#endregion

namespace 装饰模式_增加属性_坦克大战 {
    internal class Boat : Gear {
        public Boat(Tank tank) : base(tank) {
        }

        public int LeftTime { get; set; } = 60;

        public override void Move() {
            if (LeftTime > 0) {
                Console.Write("现在可以过河");
            }

            base.Move();
        }
    }
}