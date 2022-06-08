#region

using System.Collections;

#endregion

namespace 迭代器模式_NET_IEnumerable;

public class Spectrum : IEnumerable {
    private readonly string[] _colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red" };

    public IEnumerator GetEnumerator() {
        return new ColorEnumerator(_colors);
    }
}