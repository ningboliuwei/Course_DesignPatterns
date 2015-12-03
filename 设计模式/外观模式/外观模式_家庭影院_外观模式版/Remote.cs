using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式_家庭影院_外观模式版
{
	class Remote
	{
		public void WatchMovie()
		{
			Popper popper = new Popper();
			Lights lights = new Lights();
			Screen screen = new Screen();
			Projector projector = new Projector();
			Amp amp = new Amp();
			Dvd dvd = new Dvd();

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

		public void EndMovie()
		{
			Popper popper = new Popper();
			Lights lights = new Lights();
			Screen screen = new Screen();
			Projector projector = new Projector();
			Amp amp = new Amp();
			Dvd dvd = new Dvd();

			popper.Off();
			screen.Up();

			projector.Off();

			amp.Off();

			dvd.Off();
		}
	}
}
