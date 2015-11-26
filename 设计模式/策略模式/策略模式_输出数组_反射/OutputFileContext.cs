using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace 策略模式_输出数组_反射
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

		public static IOutputFileStrategy GetStrategy()
		{
			string configPath = Environment.CurrentDirectory + "\\config.txt";
			string strategyString = File.ReadAllText(configPath);

			return Assembly.Load("策略模式_输出数组_反射")
					.CreateInstance($"策略模式_输出数组_反射.Output{strategyString}FileStrategy") as IOutputFileStrategy;
		}
	}
}