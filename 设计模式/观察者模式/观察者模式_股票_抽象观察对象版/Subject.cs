#region

using System.Collections.Generic;

#endregion

namespace 观察者模式_股票_抽象观察对象版 {
    internal class Subject {
        protected List<Observer> Observers = new List<Observer>();

        public void AddObserver(Observer observer) {
            Observers.Add(observer);
        }

        public void Notify() {
            foreach (var o in Observers) {
                o.Response();
            }
        }

        public void RemoveObserver(Observer observer) {
            Observers.Remove(observer);
        }
    }
}