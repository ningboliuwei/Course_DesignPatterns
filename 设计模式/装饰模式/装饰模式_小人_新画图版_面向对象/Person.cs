using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace 装饰模式_小人_新画图版_面向对象
{
	internal class Person
	{
		protected Graphics _g;

		protected Pen _p;

		public Person()
		{
		}

		public Person(Graphics g, Pen p)
		{
			_g = g;
			_p = p;
		}

		public virtual void Show()
		{
		}
	}
}