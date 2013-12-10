using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式_手枪
{
	class Program
	{
		private static void Main(string[] args)
		{
			Pistol pistol = new Pistol();

			pistol.Reload();
			pistol.Fire();
			pistol.Fire();
			pistol.Fire();
			pistol.Fire();
			pistol.Reload();

			Console.ReadLine();
		}
	}
}