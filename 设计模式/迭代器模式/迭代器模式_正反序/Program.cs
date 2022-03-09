#region

using System;

#endregion

namespace 迭代器模式_正反序 {
    internal class Program {
        private static void Main(string[] args) {
            //SequenceAggregate list = new SequenceAggregate();
            var list = new ReverseAggregate();
            list[0] = "张三";
            list[1] = "李四";
            list[2] = "王五";
            list[3] = "赵六";
            list[4] = "周七";

            var i = list.GetIterator();
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