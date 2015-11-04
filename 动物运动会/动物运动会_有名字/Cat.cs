using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 动物运动会_有名字
{
	internal class Cat
	{
		private string name = "";

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
			return "我是" + name + ", 喵~";
		}
	}
}