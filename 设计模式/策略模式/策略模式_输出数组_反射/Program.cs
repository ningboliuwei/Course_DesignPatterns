using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式_输出数组_反射
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine(@"Please input data with the seperator, e.g. Jane,Alex,John");
			string dataString = Console.ReadLine();

			OutputFileContext context = new OutputFileContext(OutputFileContext.GetStrategy());
			context.SaveFile(dataString.Split(','));

			Console.ReadLine();
		}
	}
}