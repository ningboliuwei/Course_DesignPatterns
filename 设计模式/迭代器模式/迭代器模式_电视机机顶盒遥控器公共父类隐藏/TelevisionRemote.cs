namespace 迭代器模式_电视机机顶盒遥控器公共父类;

public class TelevisionRemote : IRemote {
    private readonly Television _television;
    private int _currentIndex = -1;

    public TelevisionRemote(Television television) {
        _television = television;
    }

    public override bool HasNext() {
        var channels = _television.GetAllChannels();
        return channels.Length != 0 && _currentIndex != channels.Length - 1;
    }

    public override Channel Next() {
        if (HasNext()) {
            _currentIndex++;
            var element = _television.GetAllChannels().ElementAt(_currentIndex);
            return element;
        }

        throw new IndexOutOfRangeException();
    }
}