namespace 观察者模式_气象站_传统版 {
    public class WeatherData {
        private readonly Device1 device1 = new Device1();

        private readonly Device2 device2 = new Device2();

        private readonly Device3 device3 = new Device3();

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
            var temperature = GetTemperature();
            var humidity = GetHumidity();
            var pressure = GetPressure();

            device1.Update(temperature, humidity, pressure);
            device2.Update(temperature, humidity, pressure);
            device3.Update(temperature, humidity, pressure);
        }
    }
}