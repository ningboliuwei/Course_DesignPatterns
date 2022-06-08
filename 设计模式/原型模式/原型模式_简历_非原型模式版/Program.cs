#region

using System;

#endregion

namespace 原型模式_简历_非原型模式版 {
    internal class Program {
        private static void Main(string[] args) {
            //最基本方式
            // Resume resume1 = new Resume("刘看山", "男", new DateTime(1988, 10, 1), "13566313313",
            //     "2006~2010：宁波大学；2010-2013：浙江大学", "2013~2014：百度；2014~2016：阿里巴巴；", "腾讯前端");
            // resume1.Display();

            //得到三份简历的方法1（创建三次）
            // Resume resume1 = new Resume("刘看山", "男", new DateTime(1988, 10, 1), "13566313313",
            //     "2006~2010：宁波大学；2010-2013：浙江大学", "2013~2014：百度；2014~2016：阿里巴巴；", "腾讯前端");
            // Resume resume2 = new Resume("刘看山", "男", new DateTime(1988, 10, 1), "13566313313",
            //     "2006~2010：宁波大学；2010-2013：浙江大学", "2013~2014：百度；2014~2016：阿里巴巴；", "Facebook前端");
            // Resume resume3 = new Resume("刘看山", "男", new DateTime(1988, 10, 1), "13566313313",
            //     "2006~2010：宁波大学；2010-2013：浙江大学", "2013~2014：百度；2014~2016：阿里巴巴；", "Google前端");
            //方法1结束

            //得到三份简历的方法2（用直接赋值）
            var resume1 = new Resume("刘看山", "男", new DateTime(1988, 10, 1), "13566313313",
                "2006~2010：宁波大学；2010-2013：浙江大学",
                "2013~2014：百度；2014~2016：阿里巴巴；", "腾讯前端");

            var resume2 = resume1;
            resume2.Post = "Facebook前端";

            var resume3 = resume1;
            resume3.Post = "Google前端";
            resume1.Name = "奥观海";
            //          //方法2结束
            //
            resume1.Display();
            resume2.Display();
            resume3.Display();

            // var x = resume1.GetHashCode();
            // var y = resume2.GetHashCode();
            // var z = resume3.GetHashCode();

            Console.ReadLine();
        }
    }
}