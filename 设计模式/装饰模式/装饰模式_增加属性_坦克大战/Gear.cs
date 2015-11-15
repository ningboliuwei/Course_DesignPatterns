using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰模式_增加属性_坦克大战
{
	class Gear : Tank
	{
		private Tank _tank;

		public Gear(Tank tank)
		{
			_tank = tank;
		}

		public override void BeAttacked()
		{
			_tank.BeAttacked();
		}

		public override void Move()
		{
			_tank.Move();
		}
	}
}