using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式_数据库_抽象工厂_反射版
{
	internal interface IDepartment
	{
		void Insert(Department department);

		Department GetDepartment(int id);
	}
}