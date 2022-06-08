#region

using 迭代器模式_电视机机顶盒无遥控器;

#endregion

var television = new Television();
var televisionChannels = television.GetAllChannels();

Console.WriteLine("Television Channels");

for (var i = 0; i < televisionChannels.Length; i++) {
    var channel = televisionChannels[i];
    Console.WriteLine($"[{channel.ChannelNumber}]{channel.ChannelName} ");
}

var setTopBox = new SetTopBox();
var setTopBoxChannels = setTopBox.GetAllChannels();

Console.WriteLine("SetTopBox Channels");

for (var i = 0; i < setTopBoxChannels.Count; i++) {
    // 这里会出错，为什么？
    var element = setTopBoxChannels.ElementAt(i);
    var channel = element.Value;
    Console.WriteLine($"[{channel.ChannelNumber}]{channel.ChannelName} ");
}

Console.ReadKey();