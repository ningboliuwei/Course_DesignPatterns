using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰模式_增加属性_坦克大战
{
	internal class Boat : Gear
	{
		private int _leftTime = 60;

		public int LeftTime
		{
			get
			{
				return this._leftTime;
			}
			set
			{
				this._leftTime = value;
			}
		}

		public override void Move()
		{
			if (LeftTime >= 0)
			{
				Console.Write("现在可以过河 ");
			}
			else
			{
				Console.Write("船消失了 ");
			}
			base.Move();
		}
	}
}