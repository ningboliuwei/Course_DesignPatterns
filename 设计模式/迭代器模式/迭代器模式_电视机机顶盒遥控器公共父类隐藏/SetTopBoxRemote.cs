namespace 迭代器模式_电视机机顶盒遥控器公共父类隐藏;

public class SetTopBoxRemote : IRemote {
    private readonly Dictionary<int, Channel> _channels;
    private int _currentIndex = -1;

    public SetTopBoxRemote(Dictionary<int, Channel> channels) {
        _channels = channels;
    }

    public override bool HasNext() {
        return _channels.Count != 0 && _currentIndex != _channels.Count - 1;
    }

    public override Channel Next() {
        if (HasNext()) {
            _currentIndex++;
            var element = _channels.ElementAt(_currentIndex);
            return element.Value;
        }

        throw new IndexOutOfRangeException();
    }
}