using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_气象站_传统版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			WeatherData weatherData = new WeatherData();

			weatherData.MeasurementsChanged();

			Console.ReadLine();
		}
	}
}