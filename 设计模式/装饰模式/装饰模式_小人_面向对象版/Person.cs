using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰模式_小人_面向对象版
{
	internal class Person
	{
		private string m_name;

		public Person(string name)
		{
			m_name = name;
		}

		public void Show()
		{
			Console.WriteLine("装扮的{0}", m_name);
		}
	}
}