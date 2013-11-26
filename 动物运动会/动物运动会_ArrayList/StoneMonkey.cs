using System;
using System.Collections.Generic;
using System.Text;

namespace 动物运动会_ArrayList
{
	internal class StoneMonkey : Monkey, IChange
	{
		public StoneMonkey()
			: base()
		{
		}

		public StoneMonkey(string name)
			: base(name)
		{
		}

		public string ChangeThing(string thing)
		{
			return base.Shout() + "我会七十二变，我变出了" + thing;
		}
	}
}