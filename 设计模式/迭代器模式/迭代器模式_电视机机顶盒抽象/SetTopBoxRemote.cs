namespace 迭代器模式_电视机机顶盒;

public class SetTopBoxRemote {
    private readonly SetTopBox _setTopBox;

    public SetTopBoxRemote(SetTopBox setTopBox) {
        _setTopBox = setTopBox;
    }

    public void ShowAllChannels() {
        var channels = _setTopBox.GetAllChannels();

        for (var i = 0; i < channels.Count; i++) {
            var channel = channels[i];
            Console.WriteLine($"[{channel.ChannelNumber}]{channel.ChannelName} ");
        }
    }
}