#region

using System.Collections.Generic;

#endregion

namespace 观察者模式_股票_单向组合关系版 {
    internal class Subject {
        protected List<Observer> Observers = new List<Observer>();

        public void AddObserver(Observer observer) {
            Observers.Add(observer);
        }

        public void Notify() {
            foreach (var o in Observers) {
                o.Response(this);
            }
        }

        public void RemoveObserver(Observer observer) {
            Observers.Remove(observer);
        }
    }
}