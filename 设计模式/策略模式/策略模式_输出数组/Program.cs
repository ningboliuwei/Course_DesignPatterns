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
			string[] data = { "tom", "jane", "alex" };
			Console.WriteLine("Choose output type(1:Text; 2:HTML; 3: XML)");

			int type;
			type = int.Parse(Console.ReadLine());
			OutputFileContext file = null;
			switch (type)
			{
				case 1:
					file = new OutputFileContext(new OutputTextFileStrategy());
					break;
				case 2:
					file = new OutputFileContext(new OutputHtmlFileStrategy());
					break;
				case 3:
					file = new OutputFileContext(new OutputXmlFileStrategy());
					break;
			}
			file.SaveFile(data);

			Console.ReadLine();
		}
	}
}