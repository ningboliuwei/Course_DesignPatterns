using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式_输出数组_反射
{
	using System.Xml;

	class OutputXMLFile : IOutputFile
	{
		public void OutputFile(string[] data)
		{
			if (data == null)
			{
				throw new Exception("Null data");
			}
			else
			{
				string filePath = "r:\\XMLReport.xml";
				XmlWriterSettings settings = new XmlWriterSettings();
				settings.Indent = true;

				try
				{
					XmlWriter writer = XmlWriter.Create(filePath, settings);
					writer.WriteStartDocument();
					writer.WriteStartElement("items");

					for (int i = 0; i < data.Length; i++)
					{
						writer.WriteElementString("item", data[i]);
					}

					writer.WriteEndDocument();
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
