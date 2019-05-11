using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_股票_抽象观察对象版 {
    class Subject {
        protected List<Observer> Observers = new List<Observer>();

        public void AddObserver(Observer observer) {
            Observers.Add(observer);
        }

        public void RemoveObserver(Observer observer) {
            Observers.Remove(observer);
        }

        public void Notify() {
            foreach (Observer o in Observers) {
                o.Response();
            }
        }
    }
}