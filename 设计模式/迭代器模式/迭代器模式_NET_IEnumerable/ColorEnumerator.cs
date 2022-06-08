#region

using System;
using System.Collections;

#endregion

namespace 迭代器模式_NET_IEnumerable;

public class ColorEnumerator : IEnumerator {
    private readonly string[] _colors;
    private int _position = -1;

    public ColorEnumerator(string[] theColors) {
        _colors = new string[theColors.Length];

        for (var i = 0; i < theColors.Length; i++) {
            _colors[i] = theColors[i];
        }
    }

    public object Current {
        get {
            if (_position == -1) {
                throw new InvalidOperationException();
            }

            if (_position >= _colors.Length) {
                throw new InvalidOperationException();
            }

            return _colors[_position];
        }
    }

    public bool MoveNext() {
        if (_position < _colors.Length - 1) {
            _position++;
            return true;
        }

        return false;
    }

    public void Reset() {
        _position = -1;
    }
}