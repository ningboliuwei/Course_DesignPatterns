using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_电脑
{
	internal class DellPCBuilder : PCBuilder
	{
		public override void BuildCPU()
		{
			Console.WriteLine("DELL CPU");
		}

		public override void BuildRAM()
		{
			Console.WriteLine("DELL RAM");
		}

		public override void BuildMonitor()
		{
			Console.WriteLine("DELL Monitor");
		}

		public override void BuildHarddisk()
		{
			Console.WriteLine("DELL Harddisk");
		}

		public override void BuildKeyboard()
		{
			Console.WriteLine("DELL Keyboard");
		}

		public override void BuildMouse()
		{
			Console.WriteLine("DELL Mouse");
		}
	}
}