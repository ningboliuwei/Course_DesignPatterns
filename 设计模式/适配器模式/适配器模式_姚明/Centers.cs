using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式_姚明
{
	internal class Centers : Player
	{
		public Centers(string name)
			: base(name)
		{
		}

		public override void Attack()
		{
			Console.Write("中锋{0}进攻", _name);
		}

		public override void Defense()
		{
			Console.Write("中锋{0}防守", _name);
		}
	}
}