using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式_输出数组_反射
{
	using System.Configuration;
	using System.Reflection;

	internal class Program
	{
		private static void Main(string[] args)
		{
			string[] data = new string[] { "tom", "jane", "alex" };
			//Console.WriteLine("Choose output type(1:Text; 2:HTML; 3:XML");

			//int type;
			//type = int.Parse(Console.ReadLine());
			//OutputFileContext file = null;
			//switch (type)
			//{
			//	case 1:
			//		file = new OutputFileContext(new OutputHTMLFile());
			//		break;
			//	case 2:
			//		file = new OutputFileContext(new OutputTextFile());
			//		break;
			//	case 3:
			//		file = new OutputFileContext(new OutputXMLFile());
			//		break;
			//	default:
			//		break;
			//}
			//file.OutputFile(data);

			string type = ConfigurationSettings.AppSettings["OutputType"].ToString();

			string assembleName = Assembly.GetExecutingAssembly().GetName().Name;

			IOutputFile outputFile =
				(Assembly.Load(assembleName)
					.CreateInstance(
						assembleName + "." + "Output" + type.ToString() + "File",
						false,
						BindingFlags.Default,
						null,
						args,
						null,
						null)) as IOutputFile;
			OutputFileContext fileContext = new OutputFileContext(outputFile);
			fileContext.OutputFile(data);


			
			Console.ReadLine();
		}
	}
}