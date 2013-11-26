using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using 装饰模式_小人_画图版;

namespace 装饰模式
{
	internal class Finery : Person
	{
		protected Person _person;

		public Finery()
			: base()
		{
		}

		public Finery(Graphics g, Pen p)
			: base(g, p)
		{
		}

		public void Decorate(Person person)
		{
			this._person = person;
		}

		public override void Show()
		{
			if (this._person != null)
			{
				this._person.Show();
			}
		}
	}
}