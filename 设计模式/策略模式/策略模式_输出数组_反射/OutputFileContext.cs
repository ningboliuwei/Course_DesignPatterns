using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式_输出数组_反射
{
	internal class OutputFileContext
	{
		private IOutputFile m_outputFile;

		public OutputFileContext(IOutputFile outputFile)
		{
			m_outputFile = outputFile;
		}

		public void OutputFile(string[] data)
		{
			m_outputFile.OutputFile(data);
		}
	}
}