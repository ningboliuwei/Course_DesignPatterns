using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_股票_多股民版 {
    class Stock {
        public string Symbol { get; set; }
        public double Price { get; set; }

        private List<Investor> _investors = new List<Investor>();

        public void AddInvestor(Investor investor) {
            _investors.Add(investor);
        }

        public void RemoveInvestor(Investor investor) {
            _investors.Remove(investor);
        }

        public void Notify() {
            foreach (Investor investor in _investors) {
                investor.Response();
            }
        }
    }
}