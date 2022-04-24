namespace 迭代器模式_电视机机顶盒结合工厂;

public class SetTopBox {
    private readonly Dictionary<int, Channel> _channels = new();

    public SetTopBox() {
        _channels.Add(1, new Channel { ChannelNumber = 13, ChannelName = "中央1套" });
        _channels.Add(2, new Channel { ChannelNumber = 15, ChannelName = "中央5套" });
        _channels.Add(3, new Channel { ChannelNumber = 19, ChannelName = "中央8套" });
        _channels.Add(4, new Channel { ChannelNumber = 22, ChannelName = "湖南卫视" });
        _channels.Add(5, new Channel { ChannelNumber = 31, ChannelName = "浙江卫视" });
    }

    public SetTopBoxRemote CreateRemote() {
        return new SetTopBoxRemote(_channels);
    }
}