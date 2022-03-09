#region

using System.Collections.Generic;

#endregion

namespace 实验12_观察者模式_气象站 {
    internal abstract class Data {
        private readonly List<Device> _devices = new List<Device>();

        public void NotifyDevices() {
            foreach (var device in _devices) {
                device.Update(this);
            }
        }

        public void RegisterDevice(Device device) {
            _devices.Add(device);
        }

        public void RemoveDevice(int index) {
            if (index >= 0 && index < _devices.Count) {
                _devices.RemoveAt(index);
            }
        }
    }
}