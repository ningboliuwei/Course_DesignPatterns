namespace 实验12_观察者模式_气象站 {
    internal class WeatherData : Data {
        public float Humidity;
        public float Pressure;
        public float Temperature;

        public void SetMeasurements(float temperature, float humidity, float pressure) {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;

            NotifyDevices();
        }
    }
}