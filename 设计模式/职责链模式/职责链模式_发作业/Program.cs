using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式_发作业
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Student s3 = new Student("王五", null);

			Student s1 = new Student("张三", s3);
			Student s2 = new Student("李四", s1);

			Book b1 = new Book("赵六");
			s2.CheckBook(b1);

			Console.ReadLine();
		}
	}
}