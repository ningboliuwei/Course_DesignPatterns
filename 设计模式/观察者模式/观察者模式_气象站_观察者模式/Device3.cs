#region

using System;

#endregion

namespace 观察者模式_气象站_观察者模式 {
    internal class Device3 : IObserver {
        public void Update(float temperature, float humidity, float pressure) {
            Console.WriteLine("DEVICE3:\n temperature: {0}\n humidity: {1}%\n pressure: {2}\n", temperature, humidity,
                pressure);
        }
    }
}