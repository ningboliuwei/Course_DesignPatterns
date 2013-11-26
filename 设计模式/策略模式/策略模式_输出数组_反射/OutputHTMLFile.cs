using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace 策略模式_输出数组_反射
{
	internal class OutputHTMLFile : IOutputFile
	{
		public void OutputFile(string[] data)
		{
			if (data == null)
			{
				throw new Exception("Null data");
			}
			else
			{
				StringBuilder builder = new StringBuilder();
				builder.Append("<table border=1>");
				for (int i = 0; i < data.Length; i++)
				{
					builder.Append("<tr><td>" + data[i] + "</td></tr>");
				}
				builder.Append("</table>");

				try
				{
					StreamWriter writer = new StreamWriter("R:\\HTMLReport.html");
					writer.Write(builder.ToString());
					writer.Close();
				}
				catch (Exception exception)
				{
					throw new Exception(exception.Message);
				}
				Console.WriteLine("Output succeeded");
			}
		}
	}
}