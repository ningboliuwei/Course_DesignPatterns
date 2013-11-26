using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰模式_增加属性_坦克大战
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Tank tank = new Tank();

			//tank.BeAttacked();
			//tank.BeAttacked();
			//tank.BeAttacked();
			//tank.BeAttacked();
			//tank.BeAttacked();


			Console.WriteLine("[吃了护盾]");
			Shield shield = new Shield();
			shield.Decorate(tank); //加护盾


			shield.BeAttacked();
			shield.BeAttacked();
			shield.BeAttacked();
			shield.BeAttacked();
			shield.BeAttacked();
			shield.BeAttacked();
			shield.BeAttacked();
			shield.BeAttacked();
			
			
			tank.Move(); //没吃船之前的移动

			Console.WriteLine("[吃了船]");
			Boat boat = new Boat();
			boat.Decorate(shield);
			boat.Move(); //吃了船之后的移动

			Console.WriteLine("[船的时间到了]");
			boat.LeftTime = 0;
			boat.Move(); //船消失之后的移动

			boat.LeftTime = -1;
			boat.Move(); //船消失之后的移动

			//for (int i = 0; i < 5; i++)
			//{
			//	boat.BeAttacked();
			//}

			Console.ReadLine();
		}
	}
}