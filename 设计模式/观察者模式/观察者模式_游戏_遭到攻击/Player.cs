using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_游戏_遭到攻击 {
    class Player {
        public string Name { get; set; }
        private Team _team;

        public void Join(Team team) {
            _team = team;
            team.AddPlayer(this);
        }

        public void Quit(Team team) {
            _team.RemovePlayer(this);
        }

        public void BeAttacked() {
            Console.WriteLine($"{Name} 遭到攻击！");
        }

        public void CallForHelp(Player sender) {
            _team.SendHelpCommand(sender);
        }

        public void Help(Player target) {
            Console.WriteLine($"{Name} 来救你了,{target.Name}！");
        }
    }
}