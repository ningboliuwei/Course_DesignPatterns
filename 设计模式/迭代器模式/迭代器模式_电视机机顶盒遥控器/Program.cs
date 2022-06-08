#region

using 迭代器模式_电视机机顶盒遥控器;

#endregion

Console.WriteLine("Television Channels");

var television = new Television();
var televisionRemote = new TelevisionRemote(television);

while (televisionRemote.HasNext()) {
    var currentChannel = televisionRemote.Next();
    Console.WriteLine($"[{currentChannel.ChannelNumber}]{currentChannel.ChannelName} ");
}

Console.WriteLine("SetTopBox Channels");

var setTopBox = new SetTopBox();
var setTopBoxRemote = new SetTopBoxRemote(setTopBox);

while (setTopBoxRemote.HasNext()) {
    var currentChannel = setTopBoxRemote.Next();
    Console.WriteLine($"[{currentChannel.ChannelNumber}]{currentChannel.ChannelName} ");
}

Console.ReadKey();