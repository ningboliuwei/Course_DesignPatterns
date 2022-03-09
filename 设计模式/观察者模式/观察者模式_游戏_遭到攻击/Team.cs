#region

using System.Collections.Generic;

#endregion

namespace 观察者模式_游戏_遭到攻击 {
    internal class Team {
        private readonly List<Player> _players = new List<Player>();
        public string Name { get; set; }

        public void AddPlayer(Player player) {
            _players.Add(player);
        }

        public void RemovePlayer(Player player) {
            _players.Remove(player);
        }

        public void SendHelpCommand(Player target) {
            foreach (var p in _players) {
                if (p != target) {
                    p.Help(target);
                }
            }
        }
    }
}