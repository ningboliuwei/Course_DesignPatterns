namespace 外观模式_家庭影院_外观模式版 {
    internal class Remote {
        public void EndMovie() {
            var popper = new Popper();
            var lights = new Lights();
            var screen = new Screen();
            var projector = new Projector();
            var amp = new Amp();
            var dvd = new Dvd();

            popper.Off();
            screen.Up();

            projector.Off();

            amp.Off();

            dvd.Off();
        }

        public void WatchMovie() {
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
        }
    }
}