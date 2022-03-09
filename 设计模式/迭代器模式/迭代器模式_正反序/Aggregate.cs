#region

using System.Collections.Generic;

#endregion

namespace 迭代器模式_正反序 {
    internal class Aggregate {
        protected readonly IList<object> Items = new List<object>();

        public int Count => Items.Count;

        public object this[int index] {
            get => Items[index];

            set => Items.Insert(index, value);
        }
    }
}