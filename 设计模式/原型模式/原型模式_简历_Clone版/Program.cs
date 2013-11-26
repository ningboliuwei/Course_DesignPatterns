using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式_简历_Clone版 //浅表复制版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Resume a = new Resume("张三");
			a.SetPersonalInfo("男", "29");
			a.SetWorkExperience("2000-2004", "x公司");

			Resume b = a.Clone() as Resume;
			//b.SetWorkExperience("2004-2006", "Y公司");//如果取消注释呢?

			Resume c = a.Clone() as Resume;
			//c.SetWorkExperience("2006-2008", "Z公司");//如果取消注释呢?

			a.Display();
			b.Display();
			c.Display();

			//a.SetWorkExperience("1111-2111", "x公司");
			//b.SetWorkExperience("2004-2006", "Y公司");//如果取消注释呢?
			//c.SetWorkExperience("2006-2008", "Z公司");//如果取消注释呢?

			a.Display();
			b.Display();
			c.Display();

			Class1 class1 = new Class1();
			class1.Test();
			Console.ReadLine();
		}
	}
}