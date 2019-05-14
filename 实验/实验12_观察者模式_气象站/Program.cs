using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验12_观察者模式_气象站 {
    class Program {
        static void Main(string[] args) {
            var weatherData = new WeatherData();

            weatherData.RegisterDevice(new Phone {PhoneNumber = "13566311411"});
            weatherData.RegisterDevice(new Lcd {Location = "天一广场"});
            weatherData.RegisterDevice(new Phone {PhoneNumber = "13566777888"});
            weatherData.RegisterDevice(new Lcd {Location = "万科广场"});

            weatherData.SetMeasurements(30, 80, 320);
            weatherData.SetMeasurements(20, 60, 300);

            weatherData.RemoveDevice(2);
            weatherData.SetMeasurements(10, 40, 250);

            Console.ReadKey();
        }
    }
}