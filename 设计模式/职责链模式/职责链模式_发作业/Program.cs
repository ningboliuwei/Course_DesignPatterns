#region

using System;

#endregion

namespace 职责链模式_发作业 {
    internal class Program {
        private static void Main(string[] args) {
            var s3 = new Student("王五", null);

            var s1 = new Student("张三", s3);
            var s2 = new Student("李四", s1);

            var b1 = new Book("赵六");
            s2.CheckBook(b1);

            Console.ReadLine();
        }
    }
}