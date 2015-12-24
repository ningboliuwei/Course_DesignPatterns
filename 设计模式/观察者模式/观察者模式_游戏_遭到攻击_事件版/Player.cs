using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_游戏_遭到攻击_事件版
{
	class Player
	{
		public string Name { get; set; }
		private Team _team;

		public event PlayerEventHandler BeAttacked;
		public delegate void PlayerEventHandler(Player sender);

		public void Join(Team team)
		{
			_team = team;
			team.AddPlayer(this);
		}

		public void Quit(Team team)
		{
			_team.RemovePlayer(this);
		}

		public void BeAttackedMethod()
		{
			OnBeAttacked();
		}

		public void Help(Player target)
		{
			Console.WriteLine($"{Name}来救你了,{target.Name}！");
		}

		protected virtual void OnBeAttacked()
		{
			BeAttacked?.Invoke(this);
		}
	}
}