using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式_请假_职责链模式
{
	internal class CEOManager : Manager
	{
		public CEOManager(string name)
			: base(name)
		{
		}

		public override void RequestApplications(Request request)
		{
			if (request.RequestType == "请假" || request.RequestType == "加薪")
			{
				Console.WriteLine("我全部批准");
			}
			else
			{
				if (_superior != null)
				{
					Console.WriteLine(
						"{0}:{1}的{2}{3}申请 数量{4} 无权处理，交给上级",
						_name,
						request.Name,
						request.RequestContent,
						request.RequestType,
						request.Number);
					_superior.RequestApplications(request);
				}
			}
		}
	}
}