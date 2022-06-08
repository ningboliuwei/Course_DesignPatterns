#region

using System.Collections;

#endregion

namespace 实验15_迭代器模式_IEnumerator接口;

public class PersonEnumerator : IEnumerator {
    private readonly Person[] _array;
    private int _position;

    public PersonEnumerator(Person[] array) {
        _array = array.OrderByDescending(t => t.Age).ToArray();
        _position = -1;
    }

    public object Current {
        get {
            if (_position > -1 && _position < _array.Length) {
                return _array[_position];
            }

            throw new IndexOutOfRangeException();
        }
    }

    public bool MoveNext() {
        _position++;
        return _position < _array.Length;
    }

    public void Reset() {
        _position = -1;
    }
}