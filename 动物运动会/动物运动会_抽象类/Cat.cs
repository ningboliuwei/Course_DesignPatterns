using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 动物运动会_抽象类
{
	internal class Cat : Animal
	{
		public Cat()
			: base()
		{
		}

		public Cat(string name)
			: base(name)
		{
		}

		protected override string getShoutSound()
		{
			return "喵~";
		}
	}
}