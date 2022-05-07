#region

using System;
using System.Collections;

#endregion

namespace 实验15_迭代器模式_IEnumerator接口 {
    internal class PersonEnumerator : IEnumerator {
        private readonly Person[] array;

        private int position;

        public PersonEnumerator(Person[] array) {
            this.array = array;
            position = -1;
        }

        public object Current {
            get {
                if (position > -1 && position < array.Length) {
                    return array[position];
                }

                throw new IndexOutOfRangeException();
            }
        }

        public bool MoveNext() {
            position++;
            return position < array.Length;
        }

        public void Reset() {
            position = -1;
        }
    }
}