#region

using System;
using System.IO;
using System.Reflection;

#endregion

namespace 策略模式_输出数组_反射 {
    internal class OutputFileContext {
        private readonly IOutputFileStrategy _outputFileStrategy;

        public OutputFileContext(IOutputFileStrategy outputFileStrategy) {
            _outputFileStrategy = outputFileStrategy;
        }

        public static IOutputFileStrategy GetStrategy() {
            var configPath = Environment.CurrentDirectory + "\\config.txt";
            var strategyString = File.ReadAllText(configPath);

            var o = Assembly.Load("策略模式_输出数组_反射")
                .CreateInstance($"策略模式_输出数组_反射.Output{strategyString}FileStrategy") as IOutputFileStrategy;
            return o;
        }

        public void SaveFile(string[] data) {
            _outputFileStrategy.OutputFile(data);
        }
    }
}