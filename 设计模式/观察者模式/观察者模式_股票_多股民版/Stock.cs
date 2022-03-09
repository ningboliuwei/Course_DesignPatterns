#region

using System.Collections.Generic;

#endregion

namespace 观察者模式_股票_多股民版 {
    internal class Stock {
        private readonly List<Investor> _investors = new List<Investor>();
        public double Price { get; set; }
        public string Symbol { get; set; }

        public void AddInvestor(Investor investor) {
            _investors.Add(investor);
        }

        public void Notify() {
            foreach (var investor in _investors) {
                investor.Response();
            }
        }

        public void RemoveInvestor(Investor investor) {
            _investors.Remove(investor);
        }
    }
}