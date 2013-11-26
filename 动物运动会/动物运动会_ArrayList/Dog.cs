using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 动物运动会_ArrayList
{
	internal class Dog : Animal
	{
		public Dog()
			: base()
		{
		}

		public Dog(string name)
			: base(name)
		{
		}

		protected override string getShoutSound()
		{
			return "汪~";
		}
	}
}