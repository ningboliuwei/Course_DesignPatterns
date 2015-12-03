using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式_家庭影院_外观模式版
{
	class Popper
	{
		public void On()
		{
			Console.WriteLine("爆米花机已打开");
		}

		public void Off()
		{
			Console.WriteLine("爆米花机已关闭");
		}

		public void Pop()
		{
			Console.WriteLine("爆米花机开始爆米花");
		}
	}
}
