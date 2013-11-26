using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式_姚明
{
	internal abstract class Player
	{
		protected string _name;

		public Player(string name)
		{
			this._name = name;
		}

		public abstract void Attack();

		public abstract void Defense();
	}
}