using System;
using System.Collections.Generic;
using System.Text;

namespace 动物运动会_ArrayList
{
	internal class MachineCat : Cat, IChange
	{
		public MachineCat()
			: base()
		{
		}

		public MachineCat(string name)
			: base(name)
		{
		}

		public string ChangeThing(string thing)
		{
			return base.Shout() + "我有异次元口袋，我变出了" + thing;
		}
	}
}