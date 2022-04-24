namespace 迭代器模式_电视机机顶盒抽象;

public class SetTopBoxRemote {
    private readonly SetTopBox _setTopBox;
    private int _currentIndex = -1;

    public SetTopBoxRemote(SetTopBox setTopBox) {
        _setTopBox = setTopBox;
    }

    public bool HasNext() {
        var channels = _setTopBox.GetAllChannels();
        return channels.Count != 0 && _currentIndex != channels.Count - 1;
    }

    public Channel Next() {
        if (HasNext()) {
            _currentIndex++;
            var element = _setTopBox.GetAllChannels().ElementAt(_currentIndex);
            return element.Value;
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