using System;
using System.Collections.Generic;
using System.Text;

namespace 工厂方法模式_两数计算
{
	internal class Operation
	{
		private double _numberA = 0;

		private double _numberB = 0;

		public double NumberA
		{
			get
			{
				return _numberA;
			}
			set
			{
				_numberA = value;
			}
		}

		public double NumberB
		{
			get
			{
				return _numberB;
			}
			set
			{
				_numberB = value;
			}
		}

		public virtual double GetResult()
		{
			double result = 0;
			return result;
		}
	}
}