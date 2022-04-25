namespace 迭代器模式_电视机机顶盒结合工厂;

public class TelevisionRemote {
    private readonly Channel[] _channels;
    private int _currentIndex = -1;

    public TelevisionRemote(Channel[] channels) {
        _channels = channels;
    }

    public bool HasNext() {
        return _channels.Length != 0 && _currentIndex != _channels.Length - 1;
    }

    public Channel Next() {
        if (HasNext()) {
            _currentIndex++;
            var element = _channels.ElementAt(_currentIndex);

            return element;
        }

        throw new IndexOutOfRangeException();
    }

    public void ShowAllChannels() {
        while (HasNext()) {
            var currentChannel = Next();
            Console.WriteLine($"[{currentChannel.ChannelNumber}]{currentChannel.ChannelName} ");
        }
    }
}