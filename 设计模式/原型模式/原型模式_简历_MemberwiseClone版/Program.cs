using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 原型模式_简历_MemberwiseClone版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Resume resume1 = new Resume("刘看山", "男", new DateTime(1988, 10, 1), "13566313313", "2006~2010：宁波大学；2010-2013：浙江大学", "2013~2014：百度；2014~2016：阿里巴巴；", "腾讯前端");

			Resume resume2 = resume1.Clone() as Resume;
			resume2.Post = "Facebook前端";

			Resume resume3 = resume1.Clone() as Resume;
			resume3.Post = "Google前端";

			resume1.Name = "奥观海";

			resume1.Display();
			resume2.Display();
			resume3.Display();

			Console.ReadLine();
		}
	}
}