using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰模式_增加属性_坦克大战
{
	class Clock : Gear
	{
		public int LeftTime { get; set; } = 30;

		public Clock(Tank tank) : base(tank)
		{
			
		}

		public void Move()
		{
			Freeze();
			base.Move();
		}

		public void Freeze()
		{
			if (LeftTime > 0)
			{
				Console.WriteLine("所有敌方坦克冻结");
			}
		}
	}
}