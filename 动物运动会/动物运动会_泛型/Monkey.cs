using System;
using System.Collections.Generic;
using System.Text;

namespace 动物运动会_泛型
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