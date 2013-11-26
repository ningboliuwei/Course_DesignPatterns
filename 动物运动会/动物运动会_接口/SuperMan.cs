using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 动物运动会_接口
{
	internal class SuperMan : Man, IFly
	{
		public string Fly()
		{
			return "我本来就会飞";
		}
	}
}