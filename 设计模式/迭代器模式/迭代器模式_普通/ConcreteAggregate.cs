#region

using System.Collections.Generic;

#endregion

namespace 迭代器模式_普通 {
    internal class ConcreteAggregate : Aggregate {
        private readonly IList<object> _items = new List<object>();

        public int Count => _items.Count;

        public object this[int index] {
            get => _items[index];

            set => _items.Insert(index, value);
        }

        public override Iterator CreateIterator() {
            return new ConcreteIterator(this);
        }
    }
}