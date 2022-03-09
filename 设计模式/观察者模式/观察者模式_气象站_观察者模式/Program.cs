#region

using System;

#endregion

namespace 观察者模式_气象站_观察者模式 {
    internal class Program {
        private static void Main(string[] args) {
            var weatherData = new WeatherData();
            var device1 = new Device1();
            var device2 = new Device2();
            var device3 = new Device3();

            weatherData.RegisterObserver(device1);
            weatherData.RegisterObserver(device2);
            weatherData.RegisterObserver(device3);

            weatherData.RemoveObserver(device2);

            weatherData.SetMeasurements(25, 80, 800);

            Console.ReadLine();
        }
    }
}