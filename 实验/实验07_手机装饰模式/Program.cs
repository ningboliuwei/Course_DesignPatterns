#region

using System;

#endregion

namespace 实验07_手机装饰模式 {
    internal class Program {
        private static void Main(string[] args) {
            MobilePhone phone = new ApplePhone();
            phone.SendMessage();
            phone.Call();

            Console.WriteLine();

            var bluetooth = new Bluetooth(phone);
            bluetooth.SendMessage();
            bluetooth.Call();

            Console.WriteLine();
            var gps = new Gps(bluetooth);
            gps.SendMessage();
            gps.Call();

            Console.WriteLine();
            var camera = new Camera(gps);
            camera.SendMessage();
            camera.Call();

            Console.ReadKey();
        }
    }
}