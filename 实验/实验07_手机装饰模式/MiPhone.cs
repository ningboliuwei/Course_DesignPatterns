#region

using System;

#endregion

namespace 实验07_手机装饰模式 {
    internal class MiPhone : MobilePhone {
        public override void Call() {
            Console.WriteLine("小米手机语音通话");
        }

        public override void SendMessage() {
            Console.WriteLine("小米手机发送短信");
        }
    }
}