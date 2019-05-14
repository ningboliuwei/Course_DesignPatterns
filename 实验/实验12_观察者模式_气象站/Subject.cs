using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验12_观察者模式_气象站 {
    abstract class Subject {
        protected List<WeatherDataDevice> Devices = new List<WeatherDataDevice>();

        public void RegisterDevice(WeatherDataDevice device) {
            Devices.Add(device);
        }

        public void RemoveDevice(int index) {
            if (index >= 0 && index < Devices.Count) {
                Devices.RemoveAt(index);
            }
        }

        public void NotifyDevices() {
            foreach (var device in Devices) {
                device.Update(this);
            }
        }
    }
}