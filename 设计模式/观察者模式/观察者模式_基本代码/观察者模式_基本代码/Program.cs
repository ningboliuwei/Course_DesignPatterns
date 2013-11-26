using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式_基本代码
{
	class Program
	{
		static void Main(string[] args)
		{
			ConcreteSubject s = new ConcreteSubject();

			s.Attach(new ConcreteObserver(s, "X"));
			s.Attach(new ConcreteObserver(s, "Y"));
			s.Attach(new ConcreteObserver(s, "Z"));

			s.SubjectState = "ABC";
			s.Notify();

			Console.Read();
		}
	}
}
