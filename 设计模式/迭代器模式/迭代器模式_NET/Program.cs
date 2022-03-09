#region

using System;
using System.Collections.Generic;

#endregion

namespace 迭代器模式_NET {
    internal class Program {
        private static void Main(string[] args) {
            var list = new List<string>();

            list.Add("张三");
            list.Add("李四");
            list.Add("王五");
            list.Add("赵六");
            list.Add("周七");

            foreach (var s in list) {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}