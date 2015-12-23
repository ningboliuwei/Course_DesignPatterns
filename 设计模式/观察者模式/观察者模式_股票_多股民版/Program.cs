using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_股票_多股民版
{
	class Program
	{
		static void Main(string[] args)
		{
			Stock stock = new Stock() {Symbol = "SINA", Price = 120.35};

			Investor investorA = new Investor {Name = "丁蟹"};
			investorA.SetStock(stock);

			Investor investorB = new Investor {Name = "陈万贤"};
			investorB.SetStock(stock);

			Investor investorC = new Investor {Name = "周济生"};
			investorC.SetStock(stock);
			
			stock.AddInvestor(investorA);
			stock.AddInvestor(investorB);
			stock.AddInvestor(investorC);

			stock.Notify();

			stock.Price = 134.56;
			stock.Notify();

			stock.Price = 99.27;
			stock.Notify();

			Console.ReadKey();
		}
	}
}