namespace 迭代器模式_正反序 {
    internal class SequenceIterator : IIterator {
        private readonly SequenceAggregate _aggregate;

        private int current;

        public SequenceIterator(SequenceAggregate aggregate) {
            _aggregate = aggregate;
        }

        public object Current() {
            return _aggregate[current];
        }

        public object First() {
            return _aggregate[0];
        }

        public object Last() {
            return _aggregate[_aggregate.Count - 1];
        }

        public object Next() {
            object result = null;
            current++;
            if (current < _aggregate.Count) {
                result = Current();
            }

            return result;
        }
    }
}