using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_游戏_遭到攻击 {
    class Team {
        public string Name { get; set; }
        List<Player> _players = new List<Player>();

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