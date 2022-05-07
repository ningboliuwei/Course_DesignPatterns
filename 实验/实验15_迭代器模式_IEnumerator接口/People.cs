#region

using System.Collections;

#endregion

namespace 实验15_迭代器模式_IEnumerator接口 {
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