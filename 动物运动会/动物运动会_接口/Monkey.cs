using System;
using System.Collections.Generic;
using System.Text;

using 动物运动会_接口;

namespace 动物运动会
{
	internal class Monkey : Animal
	{
		public Monkey()
			: base()
		{
		}

		public Monkey(string name)
			: base(name)
		{
		}

		protected override string getShoutSound()
		{
			return "吱~";
		}
	}
}