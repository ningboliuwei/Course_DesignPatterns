using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰模式_增加属性_坦克大战
{
	internal class Tank
	{
		private int _HP = 100;

		public int HP
		{
			get
			{
				return this._HP;
			}
			set
			{
				this._HP = value;
			}
		}

		public virtual void BeAttacked()
		{
			const int DAMAGE_PER_ATTACK = 20;
			HP = HP - DAMAGE_PER_ATTACK;

			if (HP > 0)
			{
				Console.WriteLine("坦克受到攻击，HP减{0}，还有{1}", DAMAGE_PER_ATTACK, HP);
			}
			else
			{
				Console.WriteLine("坦克被击毁");
			}
		}

		public virtual void Move()
		{
			Console.WriteLine("移动中");
		}
	}
}