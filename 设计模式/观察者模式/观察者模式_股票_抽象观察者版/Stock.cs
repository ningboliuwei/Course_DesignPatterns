#region

using System.Collections.Generic;

#endregion

namespace 观察者模式_股票_抽象观察者版 {
    internal class Stock {
        private readonly List<Observer> _observers = new List<Observer>();
        public double Price { get; set; }
        public string Symbol { get; set; }

        public void AddObserver(Observer observer) {
            _observers.Add(observer);
        }

        public void Notify() {
            foreach (var o in _observers) {
                o.Response();
            }
        }

        public void RemoveObserver(Observer observer) {
            _observers.Remove(observer);
        }
    }
}