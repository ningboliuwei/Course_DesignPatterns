using System;

namespace 实验07_手机装饰模式
{
    class Camera : Module
    {
        public Camera(MobilePhone phone) : base(phone)
        {
        }

        public override void Call()
        {
            Console.WriteLine("视频通话");
        }
    }
}