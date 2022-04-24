namespace 迭代器模式_电视机机顶盒;

public class SetTopBoxRemote {
    private readonly SetTopBox _setTopBox;

    public SetTopBoxRemote(SetTopBox setTopBox) {
        _setTopBox = setTopBox;
    }

    public void ShowAllChannels() {
        var channels = _setTopBox.GetAllChannels();

        // 以下为会
        // for (var i = 0; i < channels.Count; i++) {
        //     var channel = channels[i];
        //     Console.WriteLine($"[{channel.ChannelNumber}]{channel.ChannelName} ");
        // }

        // 以下为不会出错的代码
        for (var i = 0; i < channels.Count; i++) {
            // 这里会出错，为什么？
            var element = channels.ElementAt(i);
            var channel = element.Value;
            Console.WriteLine($"[{channel.ChannelNumber}]{channel.ChannelName} ");
        }
    }
}