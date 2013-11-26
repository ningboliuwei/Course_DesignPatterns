using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式_数据库_抽象工厂_非反射版
{
	internal class Department
	{
		private int _id;

		private string _deptName;

		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				_id = value;
			}
		}

		public string DeptName
		{
			get
			{
				return _deptName;
			}
			set
			{
				_deptName = value;
			}
		}
	}
}