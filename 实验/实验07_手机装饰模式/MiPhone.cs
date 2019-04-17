using System;

namespace 实验07_手机装饰模式
{
    class MiPhone : MobilePhone
    {
        public override void SendMessage()
        {
            Console.WriteLine("小米手机发送短信");
        }

        public override void Call()
        {
            Console.WriteLine("小米手机语音通话");
        }
    }
}