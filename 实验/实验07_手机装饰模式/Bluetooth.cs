using System;

namespace 实验07_手机装饰模式
{
    class Bluetooth : Module
    {
        public Bluetooth(MobilePhone phone) : base(phone)
        {
        }

        public void Connect()
        {
            Console.WriteLine("正在连接蓝牙……");
        }

        public override void Call()
        {
            Connect();
            base.Call();
        }
    }
}