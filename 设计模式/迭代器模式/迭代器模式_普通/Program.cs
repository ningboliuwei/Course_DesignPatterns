#region

using System;
using System.Collections;
using System.Collections.Generic;

#endregion

namespace 迭代器模式_普通 {
    public static class Program {
        private static void Main(string[] args) {
            var list = new List<object> { "A", "B", "C", "D", "E", "F" };
            var concreteAggregate = new ConcreteAggregate(list);
            var iterator = concreteAggregate.CreateIterator();

            iterator.First();

            while (iterator.HasNext()) {
                Console.Write(iterator.CurrentItem() + " ");
                iterator.Next();
            }

            var list2 = new List<long>();
            var x = list2.GetEnumerator();
            
            // x.MoveNext()
            
            Console.ReadLine();
        }
    }
}