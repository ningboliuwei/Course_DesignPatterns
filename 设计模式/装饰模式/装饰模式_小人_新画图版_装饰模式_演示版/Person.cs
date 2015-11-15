using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式_小人_新画图版_装饰模式_演示版
{
	abstract class Person
	{
		protected Graphics _g;

		public Person()
		{
		}

		public Person(Graphics g)
		{
			_g = g;
		}

		public abstract void Show();
	}
}