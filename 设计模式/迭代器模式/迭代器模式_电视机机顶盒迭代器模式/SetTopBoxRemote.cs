namespace 迭代器模式_电视机机顶盒迭代器模式;

public class SetTopBoxIterator : IIterator {
    private readonly SetTopBox _setTopBox;
    private int _currentIndex = -1;

    public SetTopBoxIterator(SetTopBox setTopBox) {
        _setTopBox = setTopBox;
    }

    public Channel GetCurrentItem() {
        if (_currentIndex != -1) {
            var channels = _setTopBox.GetAllChannels();
            return channels.ElementAt(_currentIndex).Value;
        }

        return null;
    }

    public bool HasNext() {
        var channels = _setTopBox.GetAllChannels();
        return channels.Count != 0 && _currentIndex != channels.Count - 1;
    }

    public void Next() {
        if (HasNext()) {
            _currentIndex++;
        }
    }
}