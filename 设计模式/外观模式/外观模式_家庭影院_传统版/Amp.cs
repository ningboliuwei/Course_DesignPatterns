using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式_家庭影院_传统版
{
	class Amp
	{
		public void On()
		{
			Console.WriteLine("功放已打开");
		}

		public void Off()
		{
			Console.WriteLine("功放已关闭");
		}

		public void SetDvd()
		{
			Console.WriteLine("功放输入已设为 DVD");
		}

		public void SetSurround()
		{
			Console.WriteLine("功放声音已设为环绕模式");
		}

		public void SetVolume(int volume)
		{
			Console.WriteLine($"音量已设为 {volume} ");
		}
	}
}
