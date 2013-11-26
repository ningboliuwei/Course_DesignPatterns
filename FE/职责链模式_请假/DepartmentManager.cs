using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式_请假_职责链模式
{
	public class DepartmentManager : Manager
	{
		public DepartmentManager(string name)
			: base(name)
		{
		}

		public override void HandleApplications(Application application)
		{
			if (application.DayCount < 10)
			{
				Console.WriteLine("{0}:{1}的申请 数量{2} 被批准", _name, application.Name, application.DayCount);
			}
			else
			{
				Console.WriteLine("{0}:{1}的申请 数量{2} 无权处理，交给上级", _name, application.Name, application.DayCount);
				if (_superior != null)
				{
					_superior.HandleApplications(application);
				}
			}
		}
	}
}