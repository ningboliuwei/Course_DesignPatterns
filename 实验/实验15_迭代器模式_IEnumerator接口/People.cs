#region

using System.Collections;

#endregion

namespace 实验15_迭代器模式_IEnumerator接口;

public class People : IEnumerable {
    private readonly Person[] _array;

    public People(Person[] array) {
        _array = array;
    }

    public IEnumerator GetEnumerator() {
        return new PersonEnumerator(_array);
    }
}