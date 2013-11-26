using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式_请假_职责链模式
{
	public class MajorManager : Manager
	{
		public MajorManager(string name)
			: base(name)
		{
		}

		public override void RequestApplications(Request request)
		{
			if (request.RequestType == "请假" && request.Number <= 5)
			{
				Console.WriteLine(
					"{0}:{1}的{2}{3}申请 数量{4} 被批准",
					_name,
					request.Name,
					request.RequestContent,
					request.RequestType,
					request.Number);
			}
			else
			{
				Console.WriteLine(
					"{0}:{1}的{2}{3}申请 数量{4} 无权处理，交给上级",
					_name,
					request.Name,
					request.RequestContent,
					request.RequestType,
					request.Number);
				if (_superior != null)
				{
					_superior.RequestApplications(request);
				}
			}
		}
	}
}