#region

using System;
using System.IO;
using System.Text;

#endregion

namespace 策略模式_输出数组_反射 {
    internal class OutputTextFileStrategy : IOutputFileStrategy {
        public void OutputFile(string[] data) {
            if (data == null) {
                throw new Exception("Null data");
            }

            var builder = new StringBuilder();

            foreach (var s in data) {
                builder.Append("---------------");
                builder.Append(Environment.NewLine).Append(s).Append(Environment.NewLine);
            }

            builder.Append("---------------").Append(Environment.NewLine);

            try {
                var writer = new StreamWriter("D:\\DEMO\\TXTReport.txt");
                writer.Write(builder);
                writer.Close();
            }
            catch (Exception exception) {
                throw new Exception(exception.Message);
            }

            Console.WriteLine("Output .txt file succeed");
        }
    }
}