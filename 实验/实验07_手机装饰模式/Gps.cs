using System;

namespace 实验07_手机装饰模式
{
    class Gps : Module
    {
        public Gps(MobilePhone phone) : base(phone)
        {
        }

        public string Location { get; set; } = "经度 121.55 度；纬度：29.88";

        public override void SendMessage()
        {
            Console.WriteLine("短信发送地点：" + Location);
            base.SendMessage();
        }
    }
}