using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式_小人_新画图版_装饰模式_双人版
{
	abstract class Wear : Person
	{
		private Person _person;

		public Wear(Graphics g) : base(g)
		{
		}

		public void Decorate(Person person)
		{
			_person = person;
		}

		public override void Show()
		{
			_person.Show();
		}
	}
}