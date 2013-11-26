using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式_发作业
{
	internal class Student
	{
		protected string _name;

		protected Student _nextStudent;

		public Student(string name, Student nextStudent)
		{
			_name = name;
			_nextStudent = nextStudent;
		}

		public void CheckBook(Book book)
		{
			if (_name == book.Name)
			{
				Console.WriteLine("{0}：这是我的作业本，我收下了", _name);
			}
			else
			{
				if (_nextStudent != null)
				{
					Console.WriteLine("{0}：这不是我的作业本，我传给下一位同学了", _name);
					_nextStudent.CheckBook(book);
				}
				else
				{
					Console.WriteLine("{0}：这不是我的作业本，但是后面没人了，作业本没人要了", _name);
				}
			}
		}
	}
}