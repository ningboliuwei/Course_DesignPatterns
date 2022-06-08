#region

using 迭代器模式_电视机无遥控器;

#endregion

var television = new Television();
var channels = television.GetAllChannels();

for (var i = 0; i < channels.Length; i++) {
    var channel = channels[i];
    Console.WriteLine($"[{channel.ChannelNumber}]{channel.ChannelName} ");
}

Console.ReadKey();