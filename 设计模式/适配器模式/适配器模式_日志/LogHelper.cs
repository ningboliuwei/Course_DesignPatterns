#region

using System;

#endregion

namespace 适配器模式_日志 {
    internal class LogHelper //客户端原来调用的类
    {
        public virtual void Write(string s) {
            Console.WriteLine(s);
        }
    }
}