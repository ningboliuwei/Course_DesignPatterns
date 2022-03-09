#region

using System;
using System.Collections.Generic;

#endregion

namespace 原型模式_简历_内含对象深复制版 {
    internal class Resume : ICloneable {
        public Resume() {
        }

        public Resume(string name, string sex, DateTime birthDate, string phone, List<ExpInfo> eduExp,
            List<ExpInfo> workExp,
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
        public List<ExpInfo> EduExp { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Post { get; set; }
        public string Sex { get; set; }
        public List<ExpInfo> WorkExp { get; set; }

        public object Clone() {
            var resume = new Resume();
            resume.Name = Name;
            resume.Sex = Sex;
            resume.BirthDate = BirthDate;
            resume.Phone = Phone;
            resume.Phone = Phone;
            resume.EduExp = new List<ExpInfo>();

            foreach (var e in EduExp) {
                resume.EduExp.Add(new ExpInfo(e.Place, e.StartDate, e.EndDate));
            }

            resume.WorkExp = new List<ExpInfo>();
            foreach (var e in WorkExp) {
                resume.WorkExp.Add(new ExpInfo(e.Place, e.StartDate, e.EndDate));
            }

            resume.Post = Post;

            return resume;
        }

        public void Display() {
            Console.WriteLine($"姓名：{Name}");
            Console.WriteLine($"性别：{Sex}");
            Console.WriteLine($"出生日期：{BirthDate.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"电话号码：{Phone}");
            Console.WriteLine("教育经历：");
            foreach (var e in EduExp) {
                Console.WriteLine($"{e.StartDate.ToString("yyyy")} ~ {e.EndDate.ToString("yyyy")}：{e.Place}");
            }

            Console.WriteLine("工作经历：");
            foreach (var e in WorkExp) {
                Console.WriteLine($"{e.StartDate.ToString("yyyy")} ~ {e.EndDate.ToString("yyyy")}：{e.Place}");
            }

            Console.WriteLine($"应聘岗位：{Post}");
            Console.WriteLine("-----------------------------------");
        }
    }
}