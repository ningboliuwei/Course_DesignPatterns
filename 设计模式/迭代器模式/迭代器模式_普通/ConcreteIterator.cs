#region

using System;

#endregion

namespace 迭代器模式_普通 {
    public class ConcreteIterator : IIterator {
        private readonly ConcreteAggregate _aggregate;
        private int _current;

        public ConcreteIterator(ConcreteAggregate aggregate) {
            _aggregate = aggregate;
        }

        public object CurrentItem() {
            return _aggregate[_current];
        }

        public void First() {
            _current = 0;
        }

        public bool HasNext() {
            return _current != _aggregate.Count;
        }

        public void Next() {
            if (HasNext()) {
                _current++;
            }
            else {
                throw new IndexOutOfRangeException();
            }
        }
    }
}