using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_气象站_观察者模式
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			WeatherData weatherData = new WeatherData();
			Device1 device1 = new Device1();
			Device2 device2 = new Device2();
			Device3 device3 = new Device3();

			weatherData.RegisterObserver(device1);
			weatherData.RegisterObserver(device2);
			weatherData.RegisterObserver(device3);

			weatherData.RemoveObserver(device2);

			weatherData.SetMeasurements(25, 80, 800);

			Console.ReadLine();
		}
	}
}