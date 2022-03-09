#region

using System;

#endregion

namespace 装饰模式_增加属性_坦克大战 {
    internal class Shield : Gear {
        public Shield(Tank tank) : base(tank) {
        }

        public int ShieldPower { get; set; } = 100;

        public override void BeAttacked() {
            const int damagePerAttack = 20;
            ShieldPower = ShieldPower - damagePerAttack;
            if (ShieldPower > 0) {
                Console.WriteLine("坦克受到攻击，护盾减{0}，仍有{1}，坦克未受损害", damagePerAttack, ShieldPower);
            }
            else if (ShieldPower == 0) {
                Console.WriteLine("坦克受到攻击，护盾减{0}，护盾消失，坦克未受损害", damagePerAttack);
            }
            else {
                base.BeAttacked();
            }
        }
    }
}