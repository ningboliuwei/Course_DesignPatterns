﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 外观模式_基金_传统
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Stock1 s1 = new Stock1();
			Stock2 s2 = new Stock2();
			Stock3 s3 = new Stock3();

			s1.Buy();
			s2.Buy();
			s3.Buy();

			s1.Sell();
			s2.Sell();
			s3.Sell();

			Console.ReadLine();
		}
	}
}