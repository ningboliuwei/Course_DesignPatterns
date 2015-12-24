using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_游戏_遭到攻击_事件版
{
	class Program
	{
		static void Main(string[] args)
		{
			Team team = new Team() {Name = "KY 战队"};
			Player playerA = new Player {Name = "魔法师"};
			Player playerB = new Player {Name = "骑士"};
			Player playerC = new Player {Name = "矮人"};
			Player playerD = new Player {Name = "精灵"};

			playerA.Join(team);
			playerB.Join(team);
			playerC.Join(team);
			playerD.Join(team);

			Console.WriteLine($"{team.Name}公告");
			Console.WriteLine($"------------------------------");

			playerB.BeAttackedMethod();

			Console.ReadKey();
		}
	}
}