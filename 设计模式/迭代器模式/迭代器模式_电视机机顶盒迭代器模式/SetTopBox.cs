namespace 迭代器模式_电视机机顶盒迭代器模式;

public class SetTopBox : IAggregate {
    private readonly Dictionary<int, Channel> _channels = new();

    public SetTopBox() {
        _channels.Add(1, new Channel { ChannelNumber = 45, ChannelName = "金鹰卡通" });
        _channels.Add(2, new Channel { ChannelNumber = 48, ChannelName = "四海钓鱼" });
        _channels.Add(3, new Channel { ChannelNumber = 52, ChannelName = "时代美食" });
        _channels.Add(4, new Channel { ChannelNumber = 58, ChannelName = "环球旅游" });
        _channels.Add(5, new Channel { ChannelNumber = 62, ChannelName = "运动健身" });
    }

    public IIterator CreateIterator() {
        var remote = new SetTopBoxIterator(this);

        return remote;
    }

    public Dictionary<int, Channel> GetAllChannels() {
        return _channels;
    }
}