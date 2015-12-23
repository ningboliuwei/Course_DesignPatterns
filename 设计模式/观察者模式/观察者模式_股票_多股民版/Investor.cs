using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_股票_多股民版
{
	class Investor
	{
		public string Name { get; set; }
		private Stock _stock;

		public void SetStock(Stock stock)
		{
			_stock = stock;
		}

		public void Update()
		{
			Console.WriteLine($"{Name} 已得知股票 {_stock.Symbol} 的最新价格为 {_stock.Price}");
			Console.WriteLine();
		}
	}
}