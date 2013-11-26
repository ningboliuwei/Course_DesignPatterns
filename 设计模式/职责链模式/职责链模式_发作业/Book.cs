using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式_发作业
{
	public class Book
	{
		public string Name { get; set; }

		public Book(string name)
		{
			Name = name;
		}
	}
}