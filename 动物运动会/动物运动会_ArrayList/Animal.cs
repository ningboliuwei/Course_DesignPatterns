using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 动物运动会_ArrayList
{
	internal abstract class Animal
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

		public string Shout()
		{
			string resultStr = "";
			resultStr += "我是" + name + "，";

			for (int i = 0; i < shoutNum; i++)
			{
				resultStr += getShoutSound();
			}
			return resultStr;
		}

		protected abstract string getShoutSound();
	}
}