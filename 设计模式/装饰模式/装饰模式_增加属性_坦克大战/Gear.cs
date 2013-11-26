using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰模式_增加属性_坦克大战
{
	internal class Gear : Tank
	{
		private Tank _tank;

		public void Decorate(Tank tank)
		{
			this._tank = tank;
		}

		public override void BeAttacked()
		{
			if (this._tank != null)
			{
				this._tank.BeAttacked();
			}
		}

		public override void Move()
		{
			if (this._tank != null)
			{
				this._tank.Move();
			}
		}
	}
}