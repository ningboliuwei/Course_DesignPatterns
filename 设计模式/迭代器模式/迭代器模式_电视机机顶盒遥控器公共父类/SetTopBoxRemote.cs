namespace 迭代器模式_电视机机顶盒遥控器公共父类;

public class SetTopBoxRemote : IRemote {
    private readonly SetTopBox _setTopBox;
    private int _currentIndex = -1;

    public SetTopBoxRemote(SetTopBox setTopBox) {
        _setTopBox = setTopBox;
    }

    public override bool HasNext() {
        var channels = _setTopBox.GetAllChannels();
        return channels.Count != 0 && _currentIndex != channels.Count - 1;
    }

    public override Channel Next() {
        if (HasNext()) {
            _currentIndex++;
            var element = _setTopBox.GetAllChannels().ElementAt(_currentIndex);
            return element.Value;
        }

        throw new IndexOutOfRangeException();
    }
}