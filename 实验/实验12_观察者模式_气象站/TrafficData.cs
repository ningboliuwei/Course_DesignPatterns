using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验12_观察者模式_气象站 {
    class TrafficData : Subject {
        public string Street;
        public string Status;

        public void SetStatus(string street, string status) {
            Street = street;
            Status = status;

            NotifyDevices();
        }
    }
}