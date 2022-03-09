#region

using System.Collections;

#endregion

namespace 迭代器模式_NET_IEnumerable {
    internal class PersonArray : IEnumerable {
        private readonly Person[] array;

        public PersonArray(Person[] array) {
            this.array = array;
        }

        public IEnumerator GetEnumerator() {
            return new PersonEnumerator(array);
        }
    }
}