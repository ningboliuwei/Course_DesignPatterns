using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式_输出数组
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			string[] data = new string[] { "tom", "jane", "alex" };
			Console.WriteLine("Choose output type(1:Text; 2:HTML");

			int type;
			type = int.Parse(Console.ReadLine());
			OutputFileContext file = null;
			switch (type)
			{
				case 1:
					file = new OutputFileContext(new OutputTextFile());
					break;
				case 2:
					file = new OutputFileContext(new OutputHTMLFile());
					break;
				default:
					break;
			}
			file.OutputFile(data);

			Console.ReadLine();
		}
	}
}