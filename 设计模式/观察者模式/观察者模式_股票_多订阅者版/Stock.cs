using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_股票_多订阅者版
{
	class Stock
	{
		public string Symbol { get; set; }
		public double Price { get; set; }

		private List<Investor> _investors = new List<Investor>();
		private List<Phone> _phones = new List<Phone>();

		public void AddInvestor(Investor investor)
		{
			_investors.Add(investor);
		}

		public void RemoveInvestor(Investor investor)
		{
			_investors.Remove(investor);
		}

		public void AddPhone(Phone phone)
		{
			_phones.Add(phone);
		}

		public void RemovePhone(Phone phone)
		{
			_phones.Remove(phone);
		}

		public void Notify()
		{
			foreach (Investor investor in _investors)
			{
				investor.Update();
			}

			foreach (Phone phone in _phones)
			{
				phone.Update();
			}
		}
	}
}