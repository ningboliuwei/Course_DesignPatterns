using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰模式_增加属性_坦克大战
{
	internal class Tank
	{
		public int HealthPower { get; set; } = 100;

		public virtual void BeAttacked()
		{
			const int damagePerAttack = 20;
			HealthPower = HealthPower - damagePerAttack;

			if (HealthPower > 0)
			{
				Console.WriteLine("坦克受到攻击，HP减{0}，还有{1}", damagePerAttack, HealthPower);
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