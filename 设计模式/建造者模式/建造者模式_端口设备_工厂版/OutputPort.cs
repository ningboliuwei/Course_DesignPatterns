using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_端口设备_工厂版
{
	internal class OutputPort : Port
	{
		public override void Transfer()
		{
			Console.WriteLine("Output");
		}
	}
}