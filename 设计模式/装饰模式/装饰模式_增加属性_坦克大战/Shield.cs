using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰模式_增加属性_坦克大战
{
	internal class Shield : Gear
	{
		private int _shieldPower = 100;

		public int ShieldPower
		{
			get
			{
				return this._shieldPower;
			}
			set
			{
				this._shieldPower = value;
			}
		}

		public override void BeAttacked()
		{
			const int DAMAGE_PER_ATTACK = 20;
			ShieldPower = ShieldPower - DAMAGE_PER_ATTACK;
			if (ShieldPower > 0)
			{
				Console.WriteLine("受到攻击，护盾-{0}，为{1}，坦克未受损害", DAMAGE_PER_ATTACK, ShieldPower);
			}
			else if (ShieldPower == 0)
			{
				Console.WriteLine("受到攻击，护盾-{0}，为0，护盾消失，坦克未受损害", DAMAGE_PER_ATTACK);
			}
			else
			{
				base.BeAttacked();
			}
		}
	}
}