#region

using System.Collections.Generic;

#endregion

namespace 迭代器模式_普通 {
    public class ConcreteAggregate : IAggregate {
        private readonly IList<object> _items;

        public ConcreteAggregate(IList<object> items) {
            _items = items;
        }

        public int Count {
            get { return _items.Count; }
        }

        public object this[int index] {
            get { return _items[index]; }
        }

        public IIterator CreateIterator() {
            return new ConcreteIterator(this);
        }
    }
}