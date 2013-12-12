using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_气象站_观察者模式
{
	public class WeatherData : ISubject
	{
		private List<IObserver> m_observers = new List<IObserver>();

		private float m_temperature = 0;

		private float m_humidity = 0;

		private float m_pressure = 0;

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
			this.m_observers.Add(observer);
		}

		public void RemoveObserver(IObserver observer)
		{
			this.m_observers.Remove(observer);
		}

		public void NotifyObserver()
		{
			foreach (IObserver observer in this.m_observers)
			{
				observer.Update(this.m_temperature, this.m_humidity, this.m_pressure);
			}
		}

		public void MeasurementsChanged()
		{
			NotifyObserver();
		}

		public void SetMeasurements(float temperature, float humidity, float pressure)
		{
			this.m_temperature = temperature;
			this.m_humidity = humidity;
			this.m_pressure = pressure;
			MeasurementsChanged();
		}
	}
}