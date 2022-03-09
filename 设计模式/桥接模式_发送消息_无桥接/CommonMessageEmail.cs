#region

using System;

#endregion

namespace 桥接模式_发送消息_无桥接 {
    internal class CommonMessageEmail : IMessage {
        public void Send() {
            Console.WriteLine("使用电子邮件发送普通消息");
        }
    }
}