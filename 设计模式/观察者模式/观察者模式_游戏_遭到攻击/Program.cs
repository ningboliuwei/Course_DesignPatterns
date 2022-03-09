#region

using System;

#endregion

namespace 观察者模式_游戏_遭到攻击 {
    internal class Program {
        private static void Main(string[] args) {
            var team = new Team { Name = "KY 战队" };
            var playerA = new Player { Name = "魔法师" };
            var playerB = new Player { Name = "骑士" };
            var playerC = new Player { Name = "矮人" };
            var playerD = new Player { Name = "精灵" };

            playerA.Join(team);
            playerB.Join(team);
            playerC.Join(team);
            playerD.Join(team);

            Console.WriteLine($"{team.Name}公告");
            playerB.BeAttacked();
            Console.WriteLine("------------------------------");
            playerB.CallForHelp(playerB);

            Console.ReadKey();
        }
    }
}