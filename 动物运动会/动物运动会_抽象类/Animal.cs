using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 动物运动会_抽象类
{
	abstract class Animal
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
				resultStr += this.GetShoutSound();
			}
			return resultStr;
		}

		protected virtual string GetShoutSound()
		{
			return "";
		}

	
		//抽象类Animal中的成员被部分实现（抽象类中不是所有的成员都是抽象方法）
	}
}