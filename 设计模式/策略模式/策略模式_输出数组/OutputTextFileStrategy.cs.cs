using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace 策略模式_输出数组
{
	class OutputTextFileStrategy : IOutputFileStrategy
	{
		public void OutputFile(string[] data)
		{
			if (data == null)
			{
				throw new Exception("Null data");
			}
			StringBuilder builder = new StringBuilder();

			foreach (string s in data)
			{
				builder.Append("---------------");
				builder.Append(Environment.NewLine).Append(s).Append(Environment.NewLine);
			}
			builder.Append("---------------").Append(Environment.NewLine);

			try
			{
				StreamWriter writer = new StreamWriter("D:\\DEMO\\TXTReport.txt");
				writer.Write(builder);
				writer.Close();
			}
			catch (Exception exception)
			{
				throw new Exception(exception.Message);
			}
			Console.WriteLine("Output .txt file succeed");
		}
	}
}