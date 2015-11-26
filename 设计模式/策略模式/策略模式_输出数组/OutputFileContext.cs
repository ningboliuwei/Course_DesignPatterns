using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式_输出数组
{
	class OutputFileContext
	{
		private IOutputFileStrategy _outputFileStrategy;

		public OutputFileContext(IOutputFileStrategy outputFileStrategy)
		{
			_outputFileStrategy = outputFileStrategy;
		}

		public void SaveFile(string[] data)
		{
			_outputFileStrategy.OutputFile(data);
		}
	}
}