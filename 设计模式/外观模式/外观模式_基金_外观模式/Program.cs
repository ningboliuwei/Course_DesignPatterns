using System;
using System.Collections.Generic;
using System.Text;

namespace 外观模式_基金_外观模式
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Fund fund = new Fund();
			fund.BuyFund();
			fund.SellFund();

			Console.ReadLine();
		}
	}
}