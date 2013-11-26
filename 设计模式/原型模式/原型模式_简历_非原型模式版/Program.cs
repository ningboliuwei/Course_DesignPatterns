using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式_简历_非原型模式版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Resume a = new Resume("张三");
			a.SetPersonalInfo("男", "29");
			a.SetWorkExperience("2000-2004", "IBM");

			//第一步开始——现在需要三份一样的简历，下面的写法会带来问题吗？

			//Resume b = a;
			//Resume c = a;

			//a.Display();
			//b.Display();
			//c.Display();
			//第一步结束

			//第二步开始——假如a的个人信息发生了变化
			//a.SetPersonalInfo("男", "保密");
			//a.Display();
			//b.Display();
			//c.Display();
			//第二步结束

			//第三步开始——甚至简历a消失了
			//a = null;
			//a.Display();
			//b.Display();
			//c.Display();
			//第三步结束

			//第一步结束

			//第四步开始——应该写成下面的样子
            //Resume b = new Resume("张三");
            //b.SetPersonalInfo("男", "29");
            //b.SetWorkExperience("2000-2004", "IBM");

            //Resume c = new Resume("张三");
            //c.SetPersonalInfo("男", "29");
            //c.SetWorkExperience("2000-2004", "IBM");

			//a.Display();
			//b.Display();
			//c.Display();
			//第四步结束

			//第五步——重复第三和第四步
            //a.SetPersonalInfo("男", "保密");


            //a.Display();
            //b.Display();
            //c.Display();
            //第五步结束
			Console.ReadLine();
		}
	}
}