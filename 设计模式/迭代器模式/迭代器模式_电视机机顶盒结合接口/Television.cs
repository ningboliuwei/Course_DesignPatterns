namespace 迭代器模式_电视机机顶盒结合接口;

public class Television : IChannelAggregate {
    private readonly Channel[] _channels;

    public Television() {
        _channels = new[] {
            new Channel { ChannelNumber = 13, ChannelName = "中央1套" },
            new Channel { ChannelNumber = 15, ChannelName = "中央5套" },
            new Channel { ChannelNumber = 19, ChannelName = "中央8套" },
            new Channel { ChannelNumber = 22, ChannelName = "湖南卫视" },
            new Channel { ChannelNumber = 31, ChannelName = "浙江卫视" }
        };
    }

    public IRemote CreateRemote() {
        return new TelevisionRemote(_channels);
    }
}