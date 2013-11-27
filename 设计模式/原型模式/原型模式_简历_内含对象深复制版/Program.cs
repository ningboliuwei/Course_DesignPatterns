using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式_简历_内含对象深复制版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
            //第一步开始
			Resume a = new Resume("张三");
			a.SetPersonalInfo("男", "29");
			a.SetWorkExperience("2000-2004", "IBM");

			Resume b = a.Clone() as Resume;
			Resume c = a.Clone() as Resume;
		
			a.Display();
			b.Display();
			c.Display();
            //第一步结束

            //第二步开始——修改原本的工作经历
            a.SetWorkExperience("2004-2008", "Google");
            a.Display();
            b.Display();
            c.Display();
            //第二步结束

			Console.ReadLine();
		}
	}
}