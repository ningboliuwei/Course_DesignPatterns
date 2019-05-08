using System;
using System.Collections.Generic;
using System.Text;

namespace 原型模式_简历_非原型模式版
{
    class Resume
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string EduExp { get; set; }
        public string WorkExp { get; set; }
        public string Post { get; set; }

        public Resume(string name, string sex, DateTime birthDate, string phone, string eduExp, string workExp,
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
            Console.WriteLine($"教育经历：{EduExp}");
            Console.WriteLine($"工作经历：{WorkExp}");
            Console.WriteLine($"应聘岗位：{Post}");
            Console.WriteLine("--------------------------------");
        }
    }
}