namespace 适配器模式_日志_对象适配器 {
    internal class LogAdapter : ILogTarget {
        private readonly LogAdaptee _adaptee;

        public LogAdapter(LogAdaptee adaptee) {
            _adaptee = adaptee;
        }

        public void Write() {
            _adaptee.WriteLog();
        }
    }
}