#region

using System;

#endregion

namespace 外观模式_家庭影院_传统版 {
    internal class Program {
        private static void Main(string[] args) {
            var popper = new Popper();
            var lights = new Lights();
            var screen = new Screen();
            var projector = new Projector();
            var amp = new Amp();
            var dvd = new Dvd();

            popper.On();
            popper.Pop();

            lights.SetBrightness(10);

            screen.Down();

            projector.On();
            projector.SetDvd();
            projector.SetWideScreenMode();

            amp.On();
            amp.SetDvd();
            amp.SetSurround();
            amp.SetVolume(5);

            dvd.On();
            dvd.Play();

            Console.ReadKey();
        }
    }
}