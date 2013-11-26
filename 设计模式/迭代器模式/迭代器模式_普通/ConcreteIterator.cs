namespace 迭代器模式_普通
{
	internal class ConcreteIterator : Iterator
	{
		private readonly ConcreteAggregate _aggregate;

		private int current;

		public ConcreteIterator(ConcreteAggregate aggregate)
		{
			_aggregate = aggregate;
		}

		public override object First()
		{
			return _aggregate[0];
		}

		public override object Next()
		{
			object result = null;
			current++;
			if (current < _aggregate.Count)
			{
				result = _aggregate[current];
			}
			return result;
		}

		public override object Last()
		{
			return _aggregate[_aggregate.Count - 1];
		}

		public override object Current()
		{
			return _aggregate[current];
		}
	}
}