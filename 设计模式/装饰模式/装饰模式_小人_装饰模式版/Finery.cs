using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰模式_小人_装饰模式版
{
	internal class Finery : Person
	{
		protected Person _person;

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