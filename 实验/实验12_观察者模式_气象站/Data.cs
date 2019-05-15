using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验12_观察者模式_气象站 {
    abstract class Data {
        private List<Device> _devices = new List<Device>();

        public void RegisterDevice(Device device) {
            _devices.Add(device);
        }

        public void RemoveDevice(int index) {
            if (index >= 0 && index < _devices.Count) {
                _devices.RemoveAt(index);
            }
        }

        public void NotifyDevices() {
            foreach (var device in _devices) {
                device.Update(this);
            }
        }
    }
}