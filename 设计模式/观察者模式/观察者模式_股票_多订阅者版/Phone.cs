using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式_股票_多订阅者版
{
	class Phone
	{
		public string PhoneNumber { get; set; }
		private Stock _stock;

		public void SetStock(Stock stock)
		{
			_stock = stock;
		}

		public void Update()
		{
			Console.WriteLine($"手机 {PhoneNumber} 已收到股票 {_stock.Symbol} 的最新价格为 {_stock.Price}");
			Console.WriteLine();
		}
	}
}