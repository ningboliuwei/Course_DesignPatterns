#region

using System;

#endregion

namespace 桥接模式_发送消息_无桥接 {
    internal class CommonMessageSMS : IMessage {
        public void Send() {
            Console.WriteLine("使用短信发送普通消息");
        }
    }
}