#region

using System;

#endregion

namespace 观察者模式_游戏_遭到攻击 {
    internal class Player {
        private Team _team;
        public string Name { get; set; }

        public void BeAttacked() {
            Console.WriteLine($"{Name} 遭到攻击！");
        }

        public void CallForHelp(Player sender) {
            _team.SendHelpCommand(sender);
        }

        public void Help(Player target) {
            Console.WriteLine($"{Name} 来救你了,{target.Name}！");
        }

        public void Join(Team team) {
            _team = team;
            team.AddPlayer(this);
        }

        public void Quit(Team team) {
            _team.RemovePlayer(this);
        }
    }
}