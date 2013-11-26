using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式_日志_对象适配器
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			ILogTarget dbLog = new LogAdapter(new DatabaseLog());
			dbLog.Write();

			ILogTarget fileLog = new LogAdapter(new FileLog());
			fileLog.Write();

			Console.ReadLine();
		}
	}
}