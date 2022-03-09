namespace 策略模式_输出数组 {
    internal class OutputFileContext {
        private readonly IOutputFileStrategy _outputFileStrategy;

        public OutputFileContext(IOutputFileStrategy outputFileStrategy) {
            _outputFileStrategy = outputFileStrategy;
        }

        public void SaveFile(string[] data) {
            _outputFileStrategy.OutputFile(data);
        }
    }
}