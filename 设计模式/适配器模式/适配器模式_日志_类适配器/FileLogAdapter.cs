namespace 适配器模式_日志_类适配器 {
    internal class FileLogAdapter : FileLog, ILogTarget {
        public void Write() {
            WriteLog();
        }
    }
}