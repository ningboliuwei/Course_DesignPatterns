using System;
using System.Collections.Generic;
using System.Text;

namespace 迭代器模式_正反序
{
	internal class ReverseIterator : IIterator
	{
		private readonly ReverseAggregate _aggregate;

		private int current;

		public ReverseIterator(ReverseAggregate aggregate)
		{
			_aggregate = aggregate;
			current = _aggregate.Count - 1;
		}

		public object First()
		{
			return _aggregate[_aggregate.Count - 1];
		}

		public object Next()
		{
			object result = null;
			current--;
			if (current >= 0)
			{
				result = Current();
			}
			return result;
		}

		public object Last()
		{
			return _aggregate[0];
		}

		public object Current()
		{
			return _aggregate[current];
		}
	}
}