using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace 策略模式_输出数组
{
	internal class OutputTextFile : IOutputFile
	{
		public void OutputFile(string[] data)
		{
			if (data == null)
			{
				throw new Exception("Null data");
			}
			else
			{
				StringBuilder topBuilder = new StringBuilder();
				StringBuilder middleBuilder = new StringBuilder();

				foreach (string s in data)
				{
					for (int i = 0; i < s.Length; i++)
					{
						topBuilder.Append("-");
					}
					middleBuilder.Append(s);
					topBuilder.Append("+");
					middleBuilder.Append("|");
				}
				topBuilder.Append(Environment.NewLine);
				middleBuilder.Append(Environment.NewLine);

				try
				{
					StreamWriter writer = new StreamWriter("r:\\TextReport.txt");
					writer.Write(topBuilder.ToString() + middleBuilder.ToString() + topBuilder.ToString());
					writer.Close();
				}
				catch (Exception exception)
				{
					throw new Exception(exception.Message);
				}
				Console.WriteLine("Output succeed");
			}
		}
	}
}