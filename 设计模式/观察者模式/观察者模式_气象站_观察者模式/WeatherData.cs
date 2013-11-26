using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_气象站_观察者模式
{
	public class WeatherData : ISubject
	{
		private List<IObserver> observers = new List<IObserver>();

		private float _temperature = 0;

		private float _humidity = 0;

		private float _pressure = 0;

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

		public void RegisterObserver(IObserver observer)
		{
			observers.Add(observer);
		}

		public void RemoveObserver(IObserver observer)
		{
			observers.Remove(observer);
		}

		public void NotifyObserver()
		{
			foreach (IObserver observer in observers)
			{
				observer.Update(_temperature, _humidity, _pressure);
			}
		}

		public void MeasurementsChanged()
		{
			NotifyObserver();
		}

		public void SetMeasurements(float temperature, float humidity, float pressure)
		{
			_temperature = temperature;
			_humidity = humidity;
			_pressure = pressure;
			MeasurementsChanged();
		}
	}
}