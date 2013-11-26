using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式_简历_内含对象版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Resume a = new Resume("张三");
			a.SetPersonalInfo("男", "29");
			a.SetWorkExperience("2000-2004", "IBM");

			Resume b = a.Clone() as Resume;
			//b.SetWorkExperience("2004-2006", "Y公司");

			Resume c = a.Clone() as Resume;
			//c.SetWorkExperience("2006-2008", "Z公司");

			a.Display();
			b.Display();
			c.Display();

			a.SetWorkExperience("2008-2010", "Google");
			a.Display();
			b.Display();
			c.Display();

			//a.SetWorkExperience("a", "b");
			//a.Display();
			//b.Display();
			//c.Display();
			//如果取消注释会怎么样?

			Console.ReadLine();
		}
	}
}