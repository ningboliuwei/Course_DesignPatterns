namespace 迭代器模式_电视机机顶盒有遥控器2;

public class TelevisionRemote {
    private readonly Television _television;
    private int _currentIndex = -1;

    public TelevisionRemote(Television television) {
        _television = television;
    }

    public Channel GetCurrentItem() {
        if (_currentIndex != -1) {
            var channels = _television.GetAllChannels();
            return channels[_currentIndex];
        }

        return null;
    }

    public bool HasNext() {
        var channels = _television.GetAllChannels();
        return channels.Length != 0 && _currentIndex != channels.Length - 1;
    }

    public void Next() {
        if (HasNext()) {
            _currentIndex++;
        }
    }
}