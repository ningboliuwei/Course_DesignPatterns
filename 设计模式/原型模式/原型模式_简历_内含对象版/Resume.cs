using System;
using System.Collections.Generic;
using System.Text;

namespace 原型模式_简历_内含对象版
{
	class Resume : ICloneable
	{
		public string Name { get; set; }
		public string Sex { get; set; }
		public DateTime BirthDate { get; set; }
		public string Phone { get; set; }
		public List<ExpInfo> EduExp { get; set; }
		public List<ExpInfo> WorkExp { get; set; }
		public string Post { get; set; }

		public Resume()
		{
		}

		public Resume(string name, string sex, DateTime birthDate, string phone, List<ExpInfo> eduExp, List<ExpInfo> workExp,
			string post)
		{
			Name = name;
			Sex = sex;
			BirthDate = birthDate;
			Phone = phone;
			EduExp = eduExp;
			WorkExp = workExp;
			Post = post;
		}

		public void Display()
		{
			Console.WriteLine($"姓名：{Name}");
			Console.WriteLine($"性别：{Sex}");
			Console.WriteLine($"出生日期：{BirthDate.ToString("yyyy-MM-dd")}");
			Console.WriteLine($"电话号码：{Phone}");
			Console.WriteLine("教育经历：}");
			foreach (var e in EduExp)
			{
				Console.WriteLine($"{e.StartDate.ToString("yyyy")} ~ {e.EndDate.ToString("yyyy")}：{e.Place}");
			}
			Console.WriteLine("工作经历：}");
			foreach (var e in WorkExp)
			{
				Console.WriteLine($"{e.StartDate.ToString("yyyy")} ~ {e.EndDate.ToString("yyyy")}：{e.Place}");
			}
			Console.WriteLine($"应聘岗位：{Post}");
		}

		public object Clone()
		{
			return this.MemberwiseClone();
		}
	}
}