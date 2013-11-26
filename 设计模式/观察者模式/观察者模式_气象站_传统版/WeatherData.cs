using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_气象站_传统版
{
	public class WeatherData
	{
		private Device1 device1 = new Device1();

		private Device2 device2 = new Device2();

		private Device3 device3 = new Device3();

		public float GetTemperature()
		{
			return 25;
		}

		public float GetHumidity()
		{
			return 30;
		}

		public float GetPressure()
		{
			return 1000;
		}

		public void MeasurementsChanged()
		{
			float temperature = GetTemperature();
			float humidity = GetHumidity();
			float pressure = GetPressure();

			device1.Update(temperature, humidity, pressure);
			device2.Update(temperature, humidity, pressure);
			device3.Update(temperature, humidity, pressure);
		}
	}
}