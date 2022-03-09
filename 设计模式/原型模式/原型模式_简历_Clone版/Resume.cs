#region

using System;

#endregion

namespace 原型模式_简历_Clone版 {
    internal class Resume {
        public Resume() {
        }

        public Resume(string name, string sex, DateTime birthDate, string phone, string eduExp, string workExp,
            string post) {
            Name = name;
            Sex = sex;
            BirthDate = birthDate;
            Phone = phone;
            EduExp = eduExp;
            WorkExp = workExp;
            Post = post;
        }

        public DateTime BirthDate { get; set; }
        public string EduExp { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Post { get; set; }
        public string Sex { get; set; }
        public string WorkExp { get; set; }

        public Resume Clone() {
            var resume = new Resume();
            resume.Name = Name;
            resume.Sex = Sex;
            resume.BirthDate = BirthDate;
            resume.Phone = Phone;
            resume.EduExp = EduExp;
            resume.WorkExp = WorkExp;
            resume.Post = Post;
            return resume;

            //也可以写成
            //return new Resume(Name, Sex, BirthDate, Phone, EduExp, WorkExp, Post);
        }

        public void Display() {
            Console.WriteLine($"姓名：{Name}");
            Console.WriteLine($"性别：{Sex}");
            Console.WriteLine($"出生日期：{BirthDate.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"电话号码：{Phone}");
            Console.WriteLine($"教育经历：{EduExp}");
            Console.WriteLine($"工作经历：{WorkExp}");
            Console.WriteLine($"应聘岗位：{Post}");
            Console.WriteLine("-----------------------------------");
        }
    }
}