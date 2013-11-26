using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式_姚明
{
	internal class Guards : Player
	{
		public Guards(string name)
			: base(name)
		{
		}

		public override void Attack()
		{
			Console.Write("后卫{0}进攻", _name);
		}

		public override void Defense()
		{
			Console.Write("后卫{0}防守", _name);
		}
	}
}