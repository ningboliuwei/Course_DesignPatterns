namespace 适配器模式_日志 {
    internal class LogHelperAdapter : LogHelper //为了适应接口的变化新建的适配器类
    {
        private readonly NewLogHelper _helper = new NewLogHelper();

        public override void Write(string s) {
            _helper.WriteLog(s);
        }
    }
}