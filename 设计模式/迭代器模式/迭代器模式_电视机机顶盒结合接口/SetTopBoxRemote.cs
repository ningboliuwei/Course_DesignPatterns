namespace 迭代器模式_电视机机顶盒结合接口;

public class SetTopBoxRemote : IRemote {
    private readonly Dictionary<int, Channel> _channels;
    private int _currentIndex = -1;

    public SetTopBoxRemote(Dictionary<int, Channel> channels) {
        _channels = channels;
    }

    public bool HasNext() {
        return _channels.Count != 0 && _currentIndex != _channels.Count - 1;
    }

    public Channel Next() {
        if (HasNext()) {
            _currentIndex++;
            var element = _channels.ElementAt(_currentIndex);

            return element.Value;
        }

        throw new IndexOutOfRangeException();
    }
}