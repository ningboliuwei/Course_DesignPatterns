#region

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

#endregion

namespace 原型模式_简历_序列化深复制版 {
    [Serializable]
    internal class Resume : ICloneable {
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
            Resume copy;
            var tempFilePath = Path.Combine(Environment.CurrentDirectory, "temp.dat");
            var fs = new FileStream(tempFilePath, FileMode.Create);
            var formatter = new BinaryFormatter();

            try {
                formatter.Serialize(fs, this);
            }
            catch (SerializationException e) {
                Console.WriteLine($"Failed to serialize. Reason: {e.Message}");
                throw;
            }
            finally {
                fs.Close();
            }

            var fs1 = new FileStream(tempFilePath, FileMode.Open);
            var formatter1 = new BinaryFormatter();

            try {
                copy = (Resume)formatter1.Deserialize(fs1);
            }
            catch (SerializationException e) {
                Console.WriteLine($"Failed to serialize. Reason: {e.Message}");
                throw;
            }
            finally {
                fs1.Close();
            }

            return copy;
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