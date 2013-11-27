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
            //第一步开始——通过Clone()得到三份一样的简历对象
            Resume a = new Resume("张三");
            a.SetPersonalInfo("男", "29");
            a.SetWorkExperience("2000-2004", "IBM");

            Resume b = a.Clone() as Resume;
            Resume c = a.Clone() as Resume;


            a.Display();
            b.Display();
            c.Display();
            //第一步结束

            //第二步开始——修改第一份（原本）中的个人信息
            //a.SetPersonalInfo("男", "保密");

            //a.Display();
            //b.Display();
            //c.Display();
            //第二步结束

            //第三步开始——修改第二与三份（副本）中的个人信息
            //b.SetPersonalInfo("男", "19");
            //c.SetPersonalInfo("女", "29");

            //a.Display();
            //b.Display();
            //c.Display();
            //第三步结束

            //第四步开始——修改原本的工作经历
            //a.SetWorkExperience("2004-2008", "Google");

            //a.Display();
            //b.Display();
            //c.Display();
            //第四步结束

			//Class1 class1 = new Class1();
			//class1.Test();
			Console.ReadLine();
		}
	}
}