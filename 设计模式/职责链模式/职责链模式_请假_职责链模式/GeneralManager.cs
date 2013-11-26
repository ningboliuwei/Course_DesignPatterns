using System;
using System.Collections.Generic;
using System.Text;

using 职责链模式_请假_职责链模式;

namespace 职责链模式_请假_职责链模式
{
	public class GeneralManager : Manager
	{
		public GeneralManager(string name)
			: base(name)
		{
		}

		public override void RequestApplications(Request request)
		{
			if (request.RequestType == "请假")
			{
				Console.WriteLine(
					"{0}:{1}的{2}{3}申请 数量{4} 被批准",
					_name,
					request.Name,
					request.RequestContent,
					request.RequestType,
					request.Number);
			}
			else if (request.RequestType == "加薪" && request.Number <= 500)
			{
				Console.WriteLine(
					"{0}:{1}的{2}{3}申请 数量{4} 被批准",
					_name,
					request.Name,
					request.RequestContent,
					request.RequestType,
					request.Number);
			}
			else if (request.RequestType == "加薪" && request.Number > 500)
			{
				Console.WriteLine(
					"{0}:{1}的{2}{3}申请 数量{4} 再说吧",
					_name,
					request.Name,
					request.RequestContent,
					request.RequestType,
					request.Number);
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