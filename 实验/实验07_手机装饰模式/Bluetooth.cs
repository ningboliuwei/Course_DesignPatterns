#region

using System;

#endregion

namespace 实验07_手机装饰模式 {
    internal class Bluetooth : Module {
        public Bluetooth(MobilePhone phone) : base(phone) {
        }

        public override void Call() {
            Connect();
            base.Call();
        }

        public void Connect() {
            Console.WriteLine("正在连接蓝牙……");
        }
    }
}