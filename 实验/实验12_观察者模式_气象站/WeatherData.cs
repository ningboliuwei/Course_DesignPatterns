using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验12_观察者模式_气象站 {
    class WeatherData : Subject {
        public float Temperature;
        public float Humidity;
        public float Pressure;

        public void SetMeasurements(float temperature, float humidity, float pressure) {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;

            NotifyDevices();
        }
    }
}