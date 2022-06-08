namespace 迭代器模式_电视机机顶盒遥控器公共父类;

public class Helper {
    public static void ShowAllChannels(IRemote set) {
        while (set.HasNext()) {
            var currentChannel = set.Next();
            Console.WriteLine($"[{currentChannel.ChannelNumber}]{currentChannel.ChannelName} ");
        }
    }
}