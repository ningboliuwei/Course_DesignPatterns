using System;
using System.Collections.Generic;
using System.Text;

namespace 原型模式_简历_内含对象版
{
	internal class WorkExperience
	{
		private string _timeArea;

		private string _company;

		public string TimeArea
		{
			get
			{
				return _timeArea;
			}

			set
			{
				_timeArea = value;
			}
		}

		public string Company
		{
			get
			{
				return _company;
			}

			set
			{
				_company = value;
			}
		}
	}
}