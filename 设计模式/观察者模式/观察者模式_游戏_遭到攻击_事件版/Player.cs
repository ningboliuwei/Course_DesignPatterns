#region

using System;

#endregion

namespace 观察者模式_游戏_遭到攻击_事件版 {
    internal class Player {
        public delegate void PlayerEventHandler(Player sender);

        private Team _team;
        public string Name { get; set; }

        public event PlayerEventHandler BeAttacked;

        public void BeAttackedMethod() {
            Console.WriteLine($"{Name}遭到攻击！");
            foreach (var p in _team.Players) {
                p.BeAttacked += Help;
            }

            OnBeAttacked();
        }

        public void Help(Player target) {
            Console.WriteLine($"{Name}来救你了,{target.Name}！");
        }

        public void Join(Team team) {
            _team = team;
            _team.Players.Add(this);
        }

        protected virtual void OnBeAttacked() {
            BeAttacked?.Invoke(this);
        }

        public void Quit(Team team) {
            _team.Players.Remove(this);
        }
    }
}