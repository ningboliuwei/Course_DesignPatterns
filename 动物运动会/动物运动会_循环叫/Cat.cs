using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 动物运动会_循环叫
{
	public class Cat
	{
		private string name = "";

		private int shoutNum = 3;

		public Cat(string name)
		{
			this.name = name;
		}

		public Cat()
		{
			this.name = "无名";
		}

		public string Shout()
		{
			string resultStr = "";
			resultStr += "我是" + name + ", ";

			for (int i = 0; i < shoutNum; i++)
			{
				resultStr += "喵~";
			}
			return resultStr;
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