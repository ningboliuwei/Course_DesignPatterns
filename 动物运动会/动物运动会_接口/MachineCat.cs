using System;
using System.Collections.Generic;
using System.Text;

using 动物运动会_接口;

namespace 动物运动会
{
	internal class MachineCat : Cat, IChange, IFly
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

		public string Fly()
		{
			return "我正在用竹蜻蜓飞";
		}

		//public string FastFly()
		//{
		//	return "我正在用火箭飞";
		//}
	}
}