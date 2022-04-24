namespace 迭代器模式_电视机机顶盒抽象;

public class TelevisionRemote {
    private readonly Television _television;
    private int _currentIndex = -1;

    public TelevisionRemote(Television television) {
        _television = television;
    }

    public bool HasNext() {
        var channels = _television.GetAllChannels();
        return channels.Length != 0 && _currentIndex != channels.Length - 1;
    }

    public Channel Next() {
        if (HasNext()) {
            _currentIndex++;
            var element = _television.GetAllChannels().ElementAt(_currentIndex);

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