using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式_简历_内含对象版
{
	class Program
	{
		private static void Main(string[] args)
		{
			Resume resume1 = new Resume("刘看山", "男", new DateTime(1988, 10, 1),
				"13566313313",
				new List<ExpInfo>()
				{
					new ExpInfo("宁波大学", new DateTime(2006, 1, 1), new DateTime(2010, 1, 1)),
					new ExpInfo("浙江大学", new DateTime(2010, 1, 1), new DateTime(2013, 1, 1))
				},
				new List<ExpInfo>()
				{
					new ExpInfo("百度", new DateTime(2013, 1, 1), new DateTime(2014, 1, 1)),
					new ExpInfo("阿里巴巴", new DateTime(2014, 1, 1), new DateTime(2016, 1, 1))
				}, "腾讯前端");

			Resume resume2 = resume1.Clone() as Resume;
			resume2.Post = "Facebook前端";

			Resume resume3 = resume1.Clone() as Resume;
			resume3.Post = "Google前端";

			resume1.WorkExp[0] = new ExpInfo("360", new DateTime(2013, 12, 1), new DateTime(2014, 12, 1));

			resume1.Display();
			Console.WriteLine("-----------------------------------");
			resume2.Display();
			Console.WriteLine("-----------------------------------");
			resume3.Display();
			Console.WriteLine("-----------------------------------");

			Console.ReadLine();
		}
	}
}