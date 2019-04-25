using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace 策略模式_输出数组
{
	class OutputXmlFileStrategy : IOutputFileStrategy
	{
		public void OutputFile(string[] data)
		{
			if (data == null)
			{
				throw new Exception("Null data");
			}

			try
			{
				XmlWriterSettings settings = new XmlWriterSettings();
				settings.Indent = true;

				XmlWriter writer = XmlWriter.Create("D:\\DEMO\\XMLReport.xml", settings);

				writer.WriteStartElement("strings");

				foreach (string s in data)
				{
					writer.WriteElementString("string", s);
				}

				writer.WriteEndElement();
				writer.Close();
			}
			catch (Exception exception)
			{
				throw new Exception(exception.Message);
			}
			Console.WriteLine("Output .xml file succeeded");
		}
	}
}