using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_游戏_遭到攻击_事件版
{
	class Team
	{
		public string Name { get; set; }
		public List<Player> Players { get; set; } = new List<Player>();
	}
}