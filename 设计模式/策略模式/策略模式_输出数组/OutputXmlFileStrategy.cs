#region

using System;
using System.Xml;

#endregion

namespace 策略模式_输出数组 {
    internal class OutputXmlFileStrategy : IOutputFileStrategy {
        public void OutputFile(string[] data) {
            if (data == null) {
                throw new Exception("Null data");
            }

            try {
                var settings = new XmlWriterSettings();
                settings.Indent = true;

                var writer = XmlWriter.Create("D:\\DEMO\\XMLReport.xml", settings);

                writer.WriteStartElement("strings");

                foreach (var s in data) {
                    writer.WriteElementString("string", s);
                }

                writer.WriteEndElement();
                writer.Close();
            }
            catch (Exception exception) {
                throw new Exception(exception.Message);
            }

            Console.WriteLine("Output .xml file succeeded");
        }
    }
}