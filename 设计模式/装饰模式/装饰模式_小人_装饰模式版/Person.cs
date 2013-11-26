using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰模式_小人_装饰模式版
{
	internal class Person
	{
		private string _name;

		public Person()
		{
		}

		public Person(string name)
		{
			this._name = name;
		}

		public virtual void Show()
		{
			Console.WriteLine("装扮的{0}", this._name);
		}
	}
}