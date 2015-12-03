using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式_家庭影院_外观模式版
{
	class Screen
	{
		public void Up()
		{
			Console.WriteLine("屏幕已升起");
		}

		public void Down()
		{
			Console.WriteLine("屏幕已放下");
		}
	}
}
