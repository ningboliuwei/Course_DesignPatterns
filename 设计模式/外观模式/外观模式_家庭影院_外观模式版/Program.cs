using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式_家庭影院_外观模式版
{
	class Program
	{
		static void Main(string[] args)
		{
			Remote remote = new Remote();

			remote.WatchMovie();

			Console.WriteLine("------------------------------");
			remote.EndMovie();
			Console.ReadKey();
		}
	}
}
