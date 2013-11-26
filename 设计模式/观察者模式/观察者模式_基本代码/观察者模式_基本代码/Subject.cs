using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式_基本代码
{
	abstract class Subject
	{
		private IList<Observer> observers = new List<Observer>();

		//增加观察者
		public void Attach(Observer observer)
		{
			observers.Add(observer);
		}
		//移除观察者
		public void Detach(Observer observer)
		{
			observers.Remove(observer);
		}
		//通知
		public void Notify()
		{
			foreach (Observer o in observers)
			{
				o.Update();
			}
		}
	}
}
