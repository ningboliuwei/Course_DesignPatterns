using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_股票_抽象观察者版 {
    class Stock {
        public string Symbol { get; set; }
        public double Price { get; set; }

        private List<Observer> _observers = new List<Observer>();

        public void AddObserver(Observer observer) {
            _observers.Add(observer);
        }

        public void RemoveObserver(Observer observer) {
            _observers.Remove(observer);
        }

        public void Notify() {
            foreach (Observer o in _observers) {
                o.Response();
            }
        }
    }
}