using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式_请假_职责链模式
{
	public class Request
	{
		//申请人
		public string Name { get; set; }

		//申请类别
		public string Type { get; set; }

		//申请内容
		public string Content { get; set; }

		//申请数量
		public int Number { get; set; }

		public Request(string name, string type, string content, int number)
		{
			Name = name;
			Type = type;
			Content = content;
			Number = number;
		}
	}
}