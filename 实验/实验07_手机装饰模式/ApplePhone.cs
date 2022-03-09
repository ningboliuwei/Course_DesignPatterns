#region

using System;

#endregion

namespace 实验07_手机装饰模式 {
    internal class ApplePhone : MobilePhone {
        public override void Call() {
            Console.WriteLine("苹果手机语音通话");
        }

        public override void SendMessage() {
            Console.WriteLine("苹果手机发送短信");
        }
    }
}