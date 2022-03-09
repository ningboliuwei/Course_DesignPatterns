#region

using System.Collections.Generic;

#endregion

namespace 观察者模式_股票_多订阅者版 {
    internal class Stock {
        private readonly List<Investor> _investors = new List<Investor>();
        private readonly List<Phone> _phones = new List<Phone>();
        public double Price { get; set; }
        public string Symbol { get; set; }

        public void AddInvestor(Investor investor) {
            _investors.Add(investor);
        }

        public void AddPhone(Phone phone) {
            _phones.Add(phone);
        }

        public void Notify() {
            foreach (var investor in _investors) {
                investor.Response();
            }

            foreach (var phone in _phones) {
                phone.Response();
            }
        }

        public void RemoveInvestor(Investor investor) {
            _investors.Remove(investor);
        }

        public void RemovePhone(Phone phone) {
            _phones.Remove(phone);
        }
    }
}