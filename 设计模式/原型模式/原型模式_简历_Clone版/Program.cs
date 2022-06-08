#region

using System;

#endregion

namespace 原型模式_简历_Clone版 {
    internal class Program {
        private static void Main(string[] args) {
            var resume1 = new Resume("刘看山", "男", new DateTime(1988, 10, 1), "13566313313",
                "2006~2010：宁波大学；2010-2013：浙江大学", "2013~2014：百度；2014~2016：阿里巴巴；", "腾讯前端");

            var resume2 = resume1.Clone();
            resume2.Post = "Facebook前端";

            var resume3 = resume1.Clone();
            resume3.Post = "Google前端";

            // resume1.Name = "奥观海";

            resume1.Display();
            resume2.Display();
            resume3.Display();

            var x = resume1.GetHashCode();
            var y = resume2.GetHashCode();
            var z = resume3.GetHashCode();

            Console.ReadLine();
        }
    }
}