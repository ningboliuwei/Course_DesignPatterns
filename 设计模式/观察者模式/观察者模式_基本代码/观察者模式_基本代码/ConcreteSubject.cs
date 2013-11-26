using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式_基本代码
{
	class ConcreteSubject : Subject
	{
		private string subjectState;

		//具体通知者状态
		public string SubjectState
		{
			get { return subjectState; }
			set { subjectState = value; }
		}
	}
}
