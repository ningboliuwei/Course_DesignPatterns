using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式_家庭影院_外观模式版
{
	class Lights
	{
		public void SetBrightness(int brightness)
		{
			Console.WriteLine($"灯光已调到 {brightness} 的亮度");
		}
	}
}
