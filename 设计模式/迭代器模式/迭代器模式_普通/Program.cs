#region

using System;

#endregion

namespace 迭代器模式_普通 {
    internal class Program {
        private static void Main(string[] args) {
            var list = new ConcreteAggregate();

            list[0] = "张三";
            list[1] = "李四";
            list[2] = "王五";
            list[3] = "赵六";
            list[4] = "周七";

            var i = list.CreateIterator();
            var item = i.First();
            Console.WriteLine("First:" + item);
            while (i.Current() != i.Last()) {
                Console.WriteLine(i.Current());
                i.Next();
            }

            Console.WriteLine("Last:" + i.Last());

            Console.ReadLine();
        }
    }
}