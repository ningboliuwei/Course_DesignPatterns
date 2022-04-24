namespace 迭代器模式_电视机机顶盒;

public class Remote {
    private readonly Television _television;

    public Remote(Television television) {
        _television = television;
    }

    public void ShowAllChannels() {
        var channels = _television.GetAllChannels();
        
        for (var i = 0; i < channels.Length; i++) {
            var channel = channels[i];
            Console.WriteLine($"[{channel.ChannelNumber}]{channel.ChannelName} ");
        }
    }
}