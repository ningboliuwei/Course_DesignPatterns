using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_气象站_观察者模式
{
	public interface ISubject
	{
		void RegisterObserver(IObserver observer);

		void RemoveObserver(IObserver observer);

		void NotifyObserver();
	}
}