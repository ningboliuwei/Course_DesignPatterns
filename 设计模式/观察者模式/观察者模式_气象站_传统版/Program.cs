#region

using System;

#endregion

namespace 观察者模式_气象站_传统版 {
    internal class Program {
        private static void Main(string[] args) {
            var weatherData = new WeatherData();

            weatherData.MeasurementsChanged();

            Console.ReadLine();
        }
    }
}