namespace 迭代器模式_电视机;

public class Television {
    private readonly Channel[] _channels;

    public Television() {
        _channels = new[] {
            new Channel { ChannelNumber = 1, ChannelName = "中央1套" },
            new Channel { ChannelNumber = 2, ChannelName = "中央5套" },
            new Channel { ChannelNumber = 3, ChannelName = "中央8套" },
            new Channel { ChannelNumber = 4, ChannelName = "湖南卫视" },
            new Channel { ChannelNumber = 5, ChannelName = "浙江卫视" }
        };
    }

    public Channel[] GetAllChannels() {
        return _channels;
    }
}