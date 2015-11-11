using System;

namespace 装饰模式_增加属性_坦克大战
{
	internal class Boat : Gear
	{
		public int LeftTime { get; set; } = 60;

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