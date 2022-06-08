#region

using 迭代器模式_电视机;

#endregion

namespace 迭代器模式_电视机无遥控器;

public class Television {
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

    public Channel[] GetAllChannels() {
        return _channels;
    }
}