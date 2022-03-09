#region

using System.Collections.Generic;

#endregion

namespace 观察者模式_气象站_观察者模式 {
    public class WeatherData : ISubject {
        private float m_humidity;
        private readonly List<IObserver> m_observers = new List<IObserver>();

        private float m_pressure;

        private float m_temperature;

        public void NotifyObserver() {
            foreach (var observer in m_observers) {
                observer.Update(m_temperature, m_humidity, m_pressure);
            }
        }

        public void RegisterObserver(IObserver observer) {
            m_observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer) {
            m_observers.Remove(observer);
        }

        public float GetHumidity() {
            return 30;
        }

        public float GetPressure() {
            return 1000;
        }

        public float GetTemperature() {
            return 25;
        }

        public void MeasurementsChanged() {
            NotifyObserver();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure) {
            m_temperature = temperature;
            m_humidity = humidity;
            m_pressure = pressure;
            MeasurementsChanged();
        }
    }
}