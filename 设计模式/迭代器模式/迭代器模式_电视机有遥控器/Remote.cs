namespace 迭代器模式_电视机有遥控器;

public class Remote {
    private readonly Television _television;
    private int _currentIndex = -1;

    public Remote(Television television) {
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