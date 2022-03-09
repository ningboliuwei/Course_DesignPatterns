#region

using System.Collections.Generic;

#endregion

namespace 观察者模式_游戏_遭到攻击_事件版 {
    internal class Team {
        public string Name { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();
    }
}