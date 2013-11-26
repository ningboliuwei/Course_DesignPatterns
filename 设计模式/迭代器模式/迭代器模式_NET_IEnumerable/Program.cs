using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迭代器模式_NET_IEnumerable
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Person[] array =
			{
				new Person { Name = "张三", Age = 23 }, new Person { Name = "李四", Age = 22 },
				new Person { Name = "王五", Age = 21 }, new Person { Name = "赵六", Age = 20 }
			};

			PersonArray pa = new PersonArray(array);

			foreach (Person item in pa)
			{
				Console.WriteLine(string.Format("姓名：{0}，年龄{1}", item.Name, item.Age));
			}

			Console.ReadLine();
		}
	}
}