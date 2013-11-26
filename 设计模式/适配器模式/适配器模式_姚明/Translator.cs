using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式_姚明
{
	internal class Translator : Player
	{
		private ForeignCenter wjzf = new ForeignCenter();

		public Translator(string name)
			: base(name)
		{
			wjzf.Name = name;
		}

		public override void Attack()
		{
			wjzf.JinGong();
		}

		public override void Defense()
		{
			wjzf.FangShou();

			
		}
	}
}