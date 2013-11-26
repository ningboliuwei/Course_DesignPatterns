using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 动物运动会_继承
{
	internal class Animal
	{
		protected string name = "";

		protected int shoutNum = 3;

		public Animal(string name)
		{
			this.name = name;
		}

		public Animal()
		{
			this.name = "匿名";
		}

		public int ShoutNum
		{
			get
			{
				return shoutNum;
			}

			set
			{
				shoutNum = value;
			}
		}
	}
}