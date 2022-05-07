#region

using System;
using System.Collections;
using System.Collections.Generic;

#endregion

namespace 实验15_迭代器模式_IEnumerator接口 {
    internal class Program {
        private static void Main(string[] args) {
            // Person[] array = {
            //     new Person { Name = "张三", Age = 23 }, new Person { Name = "李四", Age = 22 },
            //     new Person { Name = "王五", Age = 21 }, new Person { Name = "赵六", Age = 20 }
            // };
            //
            // var pa = new PersonArray(array);
            //
            // foreach (Person item in pa) {
            //     Console.WriteLine("姓名：{0}，年龄{1}", item.Name, item.Age);
            // }

            // 临时增加的
            int[] arr1 = { 10, 11, 12, 13 };

            foreach (var item in arr1) {
                Console.WriteLine(item);
            }

            var list = new List<int> { 10, 11, 12, 13 };

            foreach (var item in list) {
                Console.WriteLine(item);
            }


            int[] arr2 = { 10, 11, 12, 13 };
            IEnumerator enumerator = arr1.GetEnumerator();

            while (enumerator.MoveNext()) {
                int item = (int) enumerator.Current;
                Console.WriteLine(item);
            }
            
           
            
            
            
            Console.ReadLine();
        }
    }
}